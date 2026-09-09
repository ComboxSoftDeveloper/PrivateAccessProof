using BenchmarkDotNet.Attributes;
using PrivateAccessProof.Types;

namespace PrivateAccessProof.Benchmarks;

/// <summary>
/// Раздел 4. Вызов приватного метода. У рефлексии аргументы передаются
/// массивом, и он выделяется на каждом обращении.
/// </summary>
[MemoryDiagnoser]
public class InvokeBench
{
    private readonly Secret _secret = new();

    /// <summary>Прямой вызов изнутри типа.</summary>
    [Benchmark(Baseline = true)]
    public string Direct() => Subjects.InvokeDirect(_secret, 3);

    /// <summary>Вызов рефлексией.</summary>
    [Benchmark]
    public string Reflection() => Subjects.InvokeReflection(_secret, 3);

    /// <summary>Вызов через делегат.</summary>
    [Benchmark]
    public string Delegate() => Subjects.InvokeDelegate(_secret, 3);

    /// <summary>Вызов через UnsafeAccessor.</summary>
    [Benchmark]
    public string Accessor() => Subjects.InvokeAccessor(_secret, 3);
}
