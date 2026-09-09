```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method     | Job   | Toolchain | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |-----------:|----------:|----------:|-----------:|-------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     |  0.3354 ns | 0.0472 ns | 0.1377 ns |  0.2572 ns |   1.14 |    0.60 |      - |      14 B |         - |          NA |
| Reflection | net10 | net10     |  8.9606 ns | 0.2875 ns | 0.8108 ns |  8.7527 ns |  30.45 |    9.93 | 0.0014 |   2,076 B |      24 B |          NA |
| Accessor   | net10 | net10     |  0.2504 ns | 0.0295 ns | 0.0672 ns |  0.2235 ns |   0.85 |    0.36 |      - |      14 B |         - |          NA |
| Direct     | net8  | net8      |  0.2676 ns | 0.0303 ns | 0.0472 ns |  0.2436 ns |   0.91 |    0.33 |      - |      14 B |         - |          NA |
| Reflection | net8  | net8      | 33.7430 ns | 0.7022 ns | 1.8252 ns | 33.2677 ns | 114.67 |   36.38 | 0.0014 |     723 B |      24 B |          NA |
| Accessor   | net8  | net8      |  0.3115 ns | 0.0614 ns | 0.1771 ns |  0.2456 ns |   1.06 |    0.71 |      - |      14 B |         - |          NA |
| Direct     | net9  | net9      |  0.3654 ns | 0.0881 ns | 0.2599 ns |  0.2793 ns |   1.24 |    1.00 |      - |      14 B |         - |          NA |
| Reflection | net9  | net9      | 31.7177 ns | 1.7166 ns | 5.0075 ns | 29.7453 ns | 107.78 |   38.04 | 0.0014 |   1,342 B |      24 B |          NA |
| Accessor   | net9  | net9      |  0.2702 ns | 0.0664 ns | 0.1906 ns |  0.1847 ns |   0.92 |    0.73 |      - |      14 B |         - |          NA |
