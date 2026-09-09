// Поля этих типов приватные и снаружи не видны: в этом и смысл. Компилятор
// не знает, что до них добираются другими способами, и предупреждает,
// что значения нигде не читаются.
#pragma warning disable CS0414

namespace PrivateAccessProof.Types;

/// <summary>
/// Класс с приватными членами. Изображает чужую библиотеку: исходник менять
/// нельзя, а добраться до содержимого надо.
/// </summary>
internal sealed class Secret
{
    private string _token = "TopSecret";
    private int _counter = 42;

    private static string _shared = "SharedSecret";

    /// <summary>Приватный метод: к нему тоже нужен доступ.</summary>
    private string Reveal(int times) => _token + ":" + times;

    /// <summary>Приватный статический метод.</summary>
    private static string RevealShared() => _shared;

    /// <summary>
    /// Прямой доступ изнутри типа. Опора для сравнения: быстрее уже не будет,
    /// потому что это обычное чтение поля.
    /// </summary>
    internal string DirectToken => _token;

    /// <summary>Прямое чтение числа, тоже опора.</summary>
    internal int DirectCounter => _counter;

    /// <summary>Прямой вызов приватного метода.</summary>
    internal string DirectReveal(int times) => Reveal(times);
}

/// <summary>
/// Структура с приватным полем. Нужна отдельно: у структур первый аргумент
/// метода доступа обязан идти по ссылке, иначе запись уйдёт в копию.
/// </summary>
internal struct SecretValue
{
    private int _counter;

    /// <summary>Начальное значение задаётся отдельно: конструктор тут лишний.</summary>
    internal void Init(int value) => _counter = value;

    /// <summary>Прямое чтение, опора для сравнения.</summary>
    internal readonly int DirectCounter => _counter;
}
