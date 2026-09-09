using BenchmarkDotNet.Attributes;
using PrivateAccessProof.Types;

namespace PrivateAccessProof.Benchmarks;

/// <summary>
/// Раздел 2. Запись в приватное поле. Способов меньше, чем при чтении:
/// рефлексия ищет поле один раз, поиск на каждом обращении тут не мерится.
/// </summary>
[MemoryDiagnoser]
public class WriteBench
{
    private readonly Secret _secret = new();

    /// <summary>Запись рефлексией.</summary>
    [Benchmark(Baseline = true)]
    public void Reflection() => Subjects.WriteReflection(_secret, "Changed");

    /// <summary>Запись скомпилированным деревом выражений.</summary>
    [Benchmark]
    public void Expression() => Subjects.WriteExpression(_secret, "Changed");

    /// <summary>Запись методом, собранным из инструкций IL.</summary>
    [Benchmark]
    public void Emit() => Subjects.WriteEmit(_secret, "Changed");

    /// <summary>Запись через UnsafeAccessor.</summary>
    [Benchmark]
    public void Accessor() => Subjects.WriteAccessor(_secret, "Changed");
}
