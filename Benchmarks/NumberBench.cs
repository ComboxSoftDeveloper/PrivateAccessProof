using BenchmarkDotNet.Attributes;
using PrivateAccessProof.Types;

namespace PrivateAccessProof.Benchmarks;

/// <summary>
/// Раздел 3. Чтение приватного поля значимого типа. Рефлексия возвращает
/// object, поэтому число упаковывается: это видно в столбце Allocated.
/// </summary>
[MemoryDiagnoser]
public class NumberBench
{
    private readonly Secret _secret = new();

    /// <summary>Прямое чтение изнутри типа.</summary>
    [Benchmark(Baseline = true)]
    public int Direct() => Subjects.ReadNumberDirect(_secret);

    /// <summary>Рефлексия: результат приходит упакованным.</summary>
    [Benchmark]
    public int Reflection() => Subjects.ReadNumberReflection(_secret);

    /// <summary>UnsafeAccessor: упаковки нет.</summary>
    [Benchmark]
    public int Accessor() => Subjects.ReadNumberAccessor(_secret);
}
