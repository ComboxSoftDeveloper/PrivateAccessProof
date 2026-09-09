```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method           | Job   | Toolchain | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------- |------ |---------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|----------:|------------:|
| Direct           | net10 | net10     |  0.8650 ns | 0.0659 ns | 0.1433 ns |  0.8257 ns |  1.02 |    0.22 |      15 B |         - |          NA |
| ReflectionFresh  | net10 | net10     | 11.1472 ns | 0.2588 ns | 0.5287 ns | 10.8829 ns | 13.19 |    1.99 |   1,734 B |         - |          NA |
| ReflectionCached | net10 | net10     |  3.0206 ns | 0.0733 ns | 0.0720 ns |  3.0156 ns |  3.57 |    0.52 |   1,575 B |         - |          NA |
| Expression       | net10 | net10     |  1.6780 ns | 0.0796 ns | 0.0978 ns |  1.6410 ns |  1.99 |    0.31 |      43 B |         - |          NA |
| Emit             | net10 | net10     |  2.1556 ns | 0.0887 ns | 0.0787 ns |  2.1212 ns |  2.55 |    0.38 |      43 B |         - |          NA |
| Accessor         | net10 | net10     |  0.7547 ns | 0.0617 ns | 0.0633 ns |  0.7477 ns |  0.89 |    0.15 |      15 B |         - |          NA |
| Direct           | net8  | net8      |  0.7555 ns | 0.0595 ns | 0.0497 ns |  0.7444 ns |  0.89 |    0.14 |      15 B |         - |          NA |
| ReflectionFresh  | net8  | net8      | 35.7673 ns | 1.2377 ns | 3.5312 ns | 34.0574 ns | 42.33 |    7.36 |     258 B |         - |          NA |
| ReflectionCached | net8  | net8      | 24.2132 ns | 0.7003 ns | 1.9865 ns | 23.4375 ns | 28.65 |    4.72 |     772 B |         - |          NA |
| Expression       | net8  | net8      |  1.7216 ns | 0.0821 ns | 0.1416 ns |  1.6482 ns |  2.04 |    0.34 |      43 B |         - |          NA |
| Emit             | net8  | net8      |  2.3483 ns | 0.1110 ns | 0.3204 ns |  2.1708 ns |  2.78 |    0.55 |      43 B |         - |          NA |
| Accessor         | net8  | net8      |  0.8504 ns | 0.0660 ns | 0.1715 ns |  0.7516 ns |  1.01 |    0.25 |      15 B |         - |          NA |
| Direct           | net9  | net9      |  0.8108 ns | 0.0648 ns | 0.1248 ns |  0.7672 ns |  0.96 |    0.20 |      15 B |         - |          NA |
| ReflectionFresh  | net9  | net9      | 13.9551 ns | 0.2148 ns | 0.2010 ns | 13.8959 ns | 16.51 |    2.37 |   1,491 B |         - |          NA |
| ReflectionCached | net9  | net9      |  3.7259 ns | 0.1143 ns | 0.0954 ns |  3.7091 ns |  4.41 |    0.64 |   1,346 B |         - |          NA |
| Expression       | net9  | net9      |  1.7593 ns | 0.0836 ns | 0.1836 ns |  1.6691 ns |  2.08 |    0.37 |      43 B |         - |          NA |
| Emit             | net9  | net9      |  2.2218 ns | 0.0939 ns | 0.1285 ns |  2.1655 ns |  2.63 |    0.40 |      43 B |         - |          NA |
| Accessor         | net9  | net9      |  0.8131 ns | 0.0658 ns | 0.1812 ns |  0.7183 ns |  0.96 |    0.26 |      15 B |         - |          NA |
