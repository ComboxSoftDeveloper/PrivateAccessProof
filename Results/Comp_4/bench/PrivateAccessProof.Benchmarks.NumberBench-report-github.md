```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     |  0.7005 ns | 0.0318 ns | 0.0297 ns |  1.00 |    0.06 |      - |      14 B |         - |          NA |
| Reflection | net10 | net10     | 13.2518 ns | 0.2947 ns | 0.3727 ns | 18.95 |    0.95 | 0.0019 |   2,055 B |      24 B |          NA |
| Accessor   | net10 | net10     |  0.7247 ns | 0.0396 ns | 0.0351 ns |  1.04 |    0.07 |      - |      14 B |         - |          NA |
| Direct     | net8  | net8      |  0.2859 ns | 0.0493 ns | 0.0437 ns |  0.41 |    0.06 |      - |      14 B |         - |          NA |
| Reflection | net8  | net8      | 53.7143 ns | 1.0890 ns | 1.5267 ns | 76.81 |    3.86 | 0.0019 |     718 B |      24 B |          NA |
| Accessor   | net8  | net8      |  0.6866 ns | 0.0228 ns | 0.0191 ns |  0.98 |    0.05 |      - |      14 B |         - |          NA |
| Direct     | net9  | net9      |  0.6894 ns | 0.0306 ns | 0.0287 ns |  0.99 |    0.06 |      - |      14 B |         - |          NA |
| Reflection | net9  | net9      | 39.6832 ns | 0.8117 ns | 0.9348 ns | 56.75 |    2.71 | 0.0019 |   1,337 B |      24 B |          NA |
| Accessor   | net9  | net9      |  0.6936 ns | 0.0521 ns | 0.0511 ns |  0.99 |    0.08 |      - |      14 B |         - |          NA |
