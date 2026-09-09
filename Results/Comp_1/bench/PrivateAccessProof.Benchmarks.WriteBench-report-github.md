```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method     | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Reflection | net10 | net10     |  6.748 ns | 0.0263 ns | 0.0233 ns |  1.00 |    0.00 |   2,468 B |         - |          NA |
| Expression | net10 | net10     |  2.639 ns | 0.0112 ns | 0.0105 ns |  0.39 |    0.00 |      56 B |         - |          NA |
| Emit       | net10 | net10     |  3.524 ns | 0.0315 ns | 0.0294 ns |  0.52 |    0.00 |      56 B |         - |          NA |
| Accessor   | net10 | net10     |  2.029 ns | 0.0101 ns | 0.0094 ns |  0.30 |    0.00 |      31 B |         - |          NA |
| Reflection | net8  | net8      | 24.748 ns | 0.0888 ns | 0.0787 ns |  3.67 |    0.02 |     923 B |         - |          NA |
| Expression | net8  | net8      |  2.803 ns | 0.0143 ns | 0.0127 ns |  0.42 |    0.00 |      56 B |         - |          NA |
| Emit       | net8  | net8      |  3.644 ns | 0.0249 ns | 0.0233 ns |  0.54 |    0.00 |      56 B |         - |          NA |
| Accessor   | net8  | net8      |  1.846 ns | 0.0412 ns | 0.0386 ns |  0.27 |    0.01 |      31 B |         - |          NA |
| Reflection | net9  | net9      |  6.382 ns | 0.0621 ns | 0.0550 ns |  0.95 |    0.01 |   2,212 B |         - |          NA |
| Expression | net9  | net9      |  3.259 ns | 0.0891 ns | 0.1094 ns |  0.48 |    0.02 |      56 B |         - |          NA |
| Emit       | net9  | net9      |  3.745 ns | 0.0794 ns | 0.0743 ns |  0.55 |    0.01 |      56 B |         - |          NA |
| Accessor   | net9  | net9      |  1.644 ns | 0.0101 ns | 0.0089 ns |  0.24 |    0.00 |      31 B |         - |          NA |
