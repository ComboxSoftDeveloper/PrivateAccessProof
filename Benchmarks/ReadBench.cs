using BenchmarkDotNet.Attributes;
using PrivateAccessProof.Types;

namespace PrivateAccessProof.Benchmarks;

/// <summary>
/// Раздел 1. Чтение приватного поля со строкой. Смотреть надо и на время,
/// и на столбец Allocated: часть способов выделяет память на каждом обращении.
/// </summary>
[MemoryDiagnoser]
public class ReadBench
{
    private readonly Secret _secret = new();

    /// <summary>Прямое чтение изнутри типа.</summary>
    [Benchmark(Baseline = true)]
    public string Direct() => Subjects.ReadDirect(_secret);

    /// <summary>Рефлексия с поиском поля на каждом обращении.</summary>
    [Benchmark]
    public string ReflectionFresh() => Subjects.ReadReflectionFresh(_secret);

    /// <summary>Рефлексия с заранее найденным полем.</summary>
    [Benchmark]
    public string ReflectionCached() => Subjects.ReadReflectionCached(_secret);

    /// <summary>Скомпилированное дерево выражений.</summary>
    [Benchmark]
    public string Expression() => Subjects.ReadExpression(_secret);

    /// <summary>Метод, собранный из инструкций IL.</summary>
    [Benchmark]
    public string Emit() => Subjects.ReadEmit(_secret);

    /// <summary>Доступ через UnsafeAccessor.</summary>
    [Benchmark]
    public string Accessor() => Subjects.ReadAccessor(_secret);
}
