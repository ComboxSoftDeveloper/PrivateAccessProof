```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method     | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     |  0.3987 ns | 0.0193 ns | 0.0180 ns |  1.00 |    0.06 |      - |      14 B |         - |          NA |
| Reflection | net10 | net10     |  7.5632 ns | 0.0736 ns | 0.0652 ns | 19.01 |    0.82 | 0.0023 |   2,083 B |      24 B |          NA |
| Accessor   | net10 | net10     |  0.4053 ns | 0.0130 ns | 0.0115 ns |  1.02 |    0.05 |      - |      14 B |         - |          NA |
| Direct     | net8  | net8      |  0.4072 ns | 0.0110 ns | 0.0103 ns |  1.02 |    0.05 |      - |      14 B |         - |          NA |
| Reflection | net8  | net8      | 35.9214 ns | 0.7347 ns | 0.6872 ns | 90.27 |    4.19 | 0.0023 |     723 B |      24 B |          NA |
| Accessor   | net8  | net8      |  0.3919 ns | 0.0179 ns | 0.0167 ns |  0.98 |    0.06 |      - |      14 B |         - |          NA |
| Direct     | net9  | net9      |  0.3771 ns | 0.0074 ns | 0.0065 ns |  0.95 |    0.04 |      - |      14 B |         - |          NA |
| Reflection | net9  | net9      | 27.5387 ns | 0.4127 ns | 0.3860 ns | 69.20 |    3.09 | 0.0023 |   1,342 B |      24 B |          NA |
| Accessor   | net9  | net9      |  0.3595 ns | 0.0180 ns | 0.0168 ns |  0.90 |    0.06 |      - |      14 B |         - |          NA |
