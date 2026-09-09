```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method           | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------- |------ |---------- |-----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Direct           | net10 | net10     |  0.7647 ns | 0.0507 ns | 0.0474 ns |  1.00 |    0.09 |      15 B |         - |          NA |
| ReflectionFresh  | net10 | net10     | 15.4772 ns | 0.2867 ns | 0.2542 ns | 20.32 |    1.30 |   1,719 B |         - |          NA |
| ReflectionCached | net10 | net10     |  3.5407 ns | 0.0815 ns | 0.0762 ns |  4.65 |    0.30 |   1,565 B |         - |          NA |
| Expression       | net10 | net10     |  2.7431 ns | 0.1211 ns | 0.1133 ns |  3.60 |    0.27 |      38 B |         - |          NA |
| Emit             | net10 | net10     |  4.3177 ns | 0.0963 ns | 0.0900 ns |  5.67 |    0.37 |      38 B |         - |          NA |
| Accessor         | net10 | net10     |  0.7140 ns | 0.0644 ns | 0.0602 ns |  0.94 |    0.10 |      15 B |         - |          NA |
| Direct           | net8  | net8      |  0.6538 ns | 0.0872 ns | 0.1103 ns |  0.86 |    0.15 |      15 B |         - |          NA |
| ReflectionFresh  | net8  | net8      | 57.1568 ns | 1.1472 ns | 1.1781 ns | 75.02 |    4.89 |     248 B |         - |          NA |
| ReflectionCached | net8  | net8      | 33.4644 ns | 0.7269 ns | 0.8653 ns | 43.93 |    2.94 |     767 B |         - |          NA |
| Expression       | net8  | net8      |  2.5467 ns | 0.1071 ns | 0.0949 ns |  3.34 |    0.24 |      38 B |         - |          NA |
| Emit             | net8  | net8      |  3.9862 ns | 0.1157 ns | 0.1082 ns |  5.23 |    0.35 |      38 B |         - |          NA |
| Accessor         | net8  | net8      |  0.7167 ns | 0.0860 ns | 0.0805 ns |  0.94 |    0.12 |      15 B |         - |          NA |
| Direct           | net9  | net9      |  0.7097 ns | 0.0914 ns | 0.0855 ns |  0.93 |    0.12 |      15 B |         - |          NA |
| ReflectionFresh  | net9  | net9      | 20.7338 ns | 0.3582 ns | 0.3351 ns | 27.22 |    1.74 |   1,481 B |         - |          NA |
| ReflectionCached | net9  | net9      |  4.5131 ns | 0.1292 ns | 0.1208 ns |  5.92 |    0.40 |   1,341 B |         - |          NA |
| Expression       | net9  | net9      |  3.2091 ns | 0.1179 ns | 0.1103 ns |  4.21 |    0.30 |      38 B |         - |          NA |
| Emit             | net9  | net9      |  4.2983 ns | 0.1264 ns | 0.1182 ns |  5.64 |    0.38 |      38 B |         - |          NA |
| Accessor         | net9  | net9      |  0.8029 ns | 0.0891 ns | 0.0833 ns |  1.05 |    0.12 |      15 B |         - |          NA |
