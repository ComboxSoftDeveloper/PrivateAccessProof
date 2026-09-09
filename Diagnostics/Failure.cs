using PrivateAccessProof.Types;

namespace PrivateAccessProof.Diagnostics;

/// <summary>
/// Что происходит при ошибке в имени. Имя члена задаётся строкой, поэтому
/// опечатку компилятор не видит: сборка проходит, а разбирательство начинается
/// при первом вызове.
///
/// Отчёт показывает, чем именно кончается обращение к несуществующему полю
/// и когда это происходит.
/// </summary>
internal static class Failure
{
    /// <summary>Выводит, что случается при опечатке.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Метод доступа объявлен так:");
        Console.WriteLine();
        Console.WriteLine("  [UnsafeAccessor(UnsafeAccessorKind.Field, Name = \"_tokenn\")]");
        Console.WriteLine("  internal static extern ref string Missing(Secret instance);");
        Console.WriteLine();
        Console.WriteLine("Поля _tokenn в типе нет: в имени опечатка.");
        Console.WriteLine();

        Console.WriteLine("Сборка прошла: " + (typeof(Accessors) is not null));

        Secret secret = new();
        try
        {
            _ = Accessors.Missing(secret);
            Console.WriteLine("  вызов прошёл, чего быть не должно");
        }
        catch (Exception error)
        {
            Console.WriteLine("  вызов не прошёл");
            Console.WriteLine("  тип исключения: " + error.GetType().FullName);
            Console.WriteLine("  сообщение:      " + error.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Рефлексия в той же ситуации ведёт себя иначе:");

        System.Reflection.FieldInfo? field = typeof(Secret).GetField(
            "_tokenn",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

        Console.WriteLine("  GetField вернул: " + (field is null ? "null" : field.Name));
        Console.WriteLine();
        Console.WriteLine("Рефлексия отдаёт null, и проверить это можно сразу.");
        Console.WriteLine("UnsafeAccessor бросает исключение при первом вызове,");
        Console.WriteLine("и до этого момента ошибка себя не проявляет.");

        return 0;
    }
}
