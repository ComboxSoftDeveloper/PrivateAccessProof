using PrivateAccessProof.Types;

namespace PrivateAccessProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет, что все способы доступа возвращают одно и то же
/// значение и что запись доходит до исходного объекта, а не до копии.
/// Без этого замер сравнивал бы способы, часть из которых делает не то.
/// </summary>
internal static class Checks
{
    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;

        ok &= ReadAgrees();
        ok &= WriteReaches();
        
        ok &= NumberAgrees();
        ok &= InvokeAgrees();
        
        ok &= StaticMembers();
        ok &= StructNeedsRef();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");

        return ok ? 0 : 1;
    }

    /// <summary>Все способы чтения дают одну строку.</summary>
    private static bool ReadAgrees()
    {
        Console.WriteLine("Чтение приватного поля");

        Secret secret = new();
        string expected = secret.DirectToken;

        bool ok = Report("рефлексия с поиском", Subjects.ReadReflectionFresh(secret) == expected, "");
        
        ok &= Report("рефлексия с готовым полем", Subjects.ReadReflectionCached(secret) == expected, "");
        ok &= Report("дерево выражений", Subjects.ReadExpression(secret) == expected, "");
        
        ok &= Report("собранный из IL", Subjects.ReadEmit(secret) == expected, "");
        ok &= Report("UnsafeAccessor", Subjects.ReadAccessor(secret) == expected, expected);

        return ok;
    }

    /// <summary>Запись меняет сам объект, а не копию.</summary>
    private static bool WriteReaches()
    {
        Console.WriteLine();
        Console.WriteLine("Запись в приватное поле");

        bool ok = true;
        Secret first = new();

        Subjects.WriteReflection(first, "Первое");
        ok &= Report("рефлексия", first.DirectToken == "Первое", first.DirectToken);

        Secret second = new();

        Subjects.WriteExpression(second, "Второе");
        ok &= Report("дерево выражений", second.DirectToken == "Второе", second.DirectToken);

        Secret third = new();

        Subjects.WriteEmit(third, "Третье");
        ok &= Report("собранный из IL", third.DirectToken == "Третье", third.DirectToken);

        Secret fourth = new();

        Subjects.WriteAccessor(fourth, "Четвёртое");
        ok &= Report("UnsafeAccessor", fourth.DirectToken == "Четвёртое", fourth.DirectToken);

        return ok;
    }

    /// <summary>Оба способа читают одно число.</summary>
    private static bool NumberAgrees()
    {
        Console.WriteLine();
        Console.WriteLine("Поле значимого типа");

        Secret secret = new();
        int expected = secret.DirectCounter;

        bool ok = Report("рефлексия", Subjects.ReadNumberReflection(secret) == expected, "");
        ok &= Report("UnsafeAccessor", Subjects.ReadNumberAccessor(secret) == expected, expected.ToString());

        return ok;
    }

    /// <summary>Все способы вызова возвращают одну строку.</summary>
    private static bool InvokeAgrees()
    {
        Console.WriteLine();
        Console.WriteLine("Вызов приватного метода");

        Secret secret = new();
        string expected = secret.DirectReveal(3);

        bool ok = Report("рефлексия", Subjects.InvokeReflection(secret, 3) == expected, "");

        ok &= Report("делегат", Subjects.InvokeDelegate(secret, 3) == expected, "");
        ok &= Report("UnsafeAccessor", Subjects.InvokeAccessor(secret, 3) == expected, expected);

        return ok;
    }

    /// <summary>Статические члены доступны так же.</summary>
    private static bool StaticMembers()
    {
        Console.WriteLine();
        Console.WriteLine("Статические члены");

        Secret secret = new();

        bool ok = Report("статическое поле", Accessors.Shared(secret) == "SharedSecret", Accessors.Shared(secret));
        ok &= Report("статический метод", Accessors.RevealShared(secret) == "SharedSecret", "");

        return ok;
    }

    /// <summary>
    /// У структуры запись доходит до исходного значения только потому, что
    /// первый аргумент объявлен по ссылке.
    /// </summary>
    private static bool StructNeedsRef()
    {
        Console.WriteLine();
        Console.WriteLine("Поле структуры");

        SecretValue value = new();
        value.Init(7);

        Accessors.ValueCounter(ref value) = 99;

        return Report("запись дошла до исходной структуры", value.DirectCounter == 99, value.DirectCounter.ToString());
    }

    /// <summary>Одна строка отчёта.</summary>
    private static bool Report(string name, bool ok, string detail)
    {
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + (detail.Length == 0 ? "" : ": " + detail));
        return ok;
    }
}
