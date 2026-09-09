using System.Runtime.CompilerServices;
using PrivateAccessProof.Types;

namespace PrivateAccessProof;

/// <summary>
/// Все измеряемые способы. У каждого NoInlining: иначе компилятор встроит
/// метод в тело замера и часть работы удалит как ненужную.
/// </summary>
internal static class Subjects
{
    // ---------- Раздел 1: чтение приватного поля ----------

    /// <summary>Прямое чтение изнутри типа. Опора для сравнения.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadDirect(Secret instance) => instance.DirectToken;

    /// <summary>Рефлексия с поиском поля на каждом обращении.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadReflectionFresh(Secret instance) => (string)Reflectors.FindTokenField().GetValue(instance)!;

    /// <summary>Рефлексия с заранее найденным полем.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadReflectionCached(Secret instance) => (string)Reflectors.TokenField.GetValue(instance)!;

    /// <summary>Скомпилированное дерево выражений.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadExpression(Secret instance) => Reflectors.TokenByExpression(instance);

    /// <summary>Метод, собранный из инструкций IL.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadEmit(Secret instance) => Reflectors.TokenByEmit(instance);

    /// <summary>Доступ через UnsafeAccessor.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string ReadAccessor(Secret instance) => Accessors.Token(instance);

    // ---------- Раздел 2: запись приватного поля ----------

    /// <summary>Запись рефлексией с заранее найденным полем.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WriteReflection(Secret instance, string value) => Reflectors.TokenField.SetValue(instance, value);

    /// <summary>Запись скомпилированным деревом выражений.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WriteExpression(Secret instance, string value) => Reflectors.WriteByExpression(instance, value);

    /// <summary>Запись методом, собранным из инструкций IL.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WriteEmit(Secret instance, string value) => Reflectors.WriteByEmit(instance, value);

    /// <summary>Запись через UnsafeAccessor: метод возвращает ссылку на поле.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void WriteAccessor(Secret instance, string value) => Accessors.Token(instance) = value;

    // ---------- Раздел 3: значимый тип и упаковка ----------

    /// <summary>Чтение числа рефлексией: результат приходит упакованным.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ReadNumberReflection(Secret instance) => (int)Reflectors.CounterField.GetValue(instance)!;

    /// <summary>Чтение того же числа через UnsafeAccessor.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ReadNumberAccessor(Secret instance) => Accessors.Counter(instance);

    /// <summary>Прямое чтение числа, опора для сравнения.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ReadNumberDirect(Secret instance) => instance.DirectCounter;

    // ---------- Раздел 4: вызов приватного метода ----------

    /// <summary>Вызов рефлексией.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string InvokeReflection(Secret instance, int times) => (string)Reflectors.RevealMethod.Invoke(instance, [times])!;

    /// <summary>Вызов через делегат, созданный от описания метода.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string InvokeDelegate(Secret instance, int times) => Reflectors.RevealByDelegate(instance, times);

    /// <summary>Вызов через UnsafeAccessor.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string InvokeAccessor(Secret instance, int times) => Accessors.Reveal(instance, times);

    /// <summary>Прямой вызов изнутри типа, опора для сравнения.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string InvokeDirect(Secret instance, int times) => instance.DirectReveal(times);
}
