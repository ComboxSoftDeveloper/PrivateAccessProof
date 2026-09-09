```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method           | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio  | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------- |------ |---------- |-----------:|----------:|----------:|-------:|--------:|----------:|----------:|------------:|
| Direct           | net10 | net10     |  0.3006 ns | 0.0108 ns | 0.0101 ns |   1.00 |    0.05 |      15 B |         - |          NA |
| ReflectionFresh  | net10 | net10     | 11.6615 ns | 0.1065 ns | 0.0944 ns |  38.83 |    1.28 |   1,734 B |         - |          NA |
| ReflectionCached | net10 | net10     |  2.2552 ns | 0.0187 ns | 0.0156 ns |   7.51 |    0.25 |   1,575 B |         - |          NA |
| Expression       | net10 | net10     |  1.5103 ns | 0.0169 ns | 0.0158 ns |   5.03 |    0.17 |      43 B |         - |          NA |
| Emit             | net10 | net10     |  2.2986 ns | 0.0200 ns | 0.0187 ns |   7.65 |    0.25 |      43 B |         - |          NA |
| Accessor         | net10 | net10     |  0.2898 ns | 0.0114 ns | 0.0107 ns |   0.96 |    0.05 |      15 B |         - |          NA |
| Direct           | net8  | net8      |  0.8784 ns | 0.0088 ns | 0.0073 ns |   2.93 |    0.10 |      15 B |         - |          NA |
| ReflectionFresh  | net8  | net8      | 38.2536 ns | 0.1251 ns | 0.1170 ns | 127.38 |    4.10 |     258 B |         - |          NA |
| ReflectionCached | net8  | net8      | 22.7624 ns | 0.0811 ns | 0.0758 ns |  75.79 |    2.44 |     772 B |         - |          NA |
| Expression       | net8  | net8      |  1.6712 ns | 0.0160 ns | 0.0150 ns |   5.56 |    0.18 |      43 B |         - |          NA |
| Emit             | net8  | net8      |  2.4112 ns | 0.0169 ns | 0.0158 ns |   8.03 |    0.26 |      43 B |         - |          NA |
| Accessor         | net8  | net8      |  0.7994 ns | 0.0092 ns | 0.0086 ns |   2.66 |    0.09 |      15 B |         - |          NA |
| Direct           | net9  | net9      |  0.8098 ns | 0.0075 ns | 0.0066 ns |   2.70 |    0.09 |      15 B |         - |          NA |
| ReflectionFresh  | net9  | net9      | 15.2240 ns | 0.0399 ns | 0.0312 ns |  50.69 |    1.63 |   1,491 B |         - |          NA |
| ReflectionCached | net9  | net9      |  3.1433 ns | 0.0120 ns | 0.0112 ns |  10.47 |    0.34 |   1,346 B |         - |          NA |
| Expression       | net9  | net9      |  1.6124 ns | 0.0205 ns | 0.0191 ns |   5.37 |    0.18 |      43 B |         - |          NA |
| Emit             | net9  | net9      |  2.3792 ns | 0.0243 ns | 0.0203 ns |   7.92 |    0.26 |      43 B |         - |          NA |
| Accessor         | net9  | net9      |  0.7941 ns | 0.0128 ns | 0.0114 ns |   2.64 |    0.09 |      15 B |         - |          NA |
