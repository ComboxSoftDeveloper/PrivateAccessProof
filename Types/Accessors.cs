using System.Runtime.CompilerServices;

namespace PrivateAccessProof.Types;

/// <summary>
/// Доступ через UnsafeAccessor. Атрибут ставится на метод, объявленный
/// как extern static: тела у метода нет, его подставляет рантайм.
///
/// Имя члена задаётся строкой, поэтому опечатка ловится не компилятором,
/// а при первом вызове: летит MissingFieldException или MissingMethodException.
/// Иерархия типов при поиске не обходится — ищется только в том типе, который
/// указан первым аргументом.
/// </summary>
internal static class Accessors
{
    /// <summary>
    /// Ссылка на приватное поле. Возврат по ссылке даёт и чтение, и запись
    /// одним методом.
    /// </summary>
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_token")]
    internal static extern ref string Token(Secret instance);

    /// <summary>Ссылка на приватное поле значимого типа.</summary>
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_counter")]
    internal static extern ref int Counter(Secret instance);

    /// <summary>Ссылка на приватное статическое поле.</summary>
    [UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "_shared")]
    internal static extern ref string Shared(Secret unused);

    /// <summary>Вызов приватного метода.</summary>
    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "Reveal")]
    internal static extern string Reveal(Secret instance, int times);

    /// <summary>Вызов приватного статического метода.</summary>
    [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = "RevealShared")]
    internal static extern string RevealShared(Secret unused);

    /// <summary>
    /// Поле структуры. Первый аргумент идёт по ссылке: иначе доступ
    /// достался бы копии, и запись потерялась бы.
    /// </summary>
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_counter")]
    internal static extern ref int ValueCounter(ref SecretValue instance);

    /// <summary>
    /// Поле, которого в типе нет. Нужен, чтобы показать, когда именно ловится
    /// опечатка в имени.
    /// </summary>
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_tokenn")]
    internal static extern ref string Missing(Secret instance);
}
