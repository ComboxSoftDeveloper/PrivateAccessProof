```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method     | Job   | Toolchain | Mean     | Error    | StdDev   | Median    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |---------:|---------:|---------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     | 11.70 ns | 0.827 ns | 2.412 ns | 10.984 ns |  1.04 |    0.29 | 0.0029 |   1,808 B |      48 B |        1.00 |
| Reflection | net10 | net10     | 33.45 ns | 1.797 ns | 5.214 ns | 30.726 ns |  2.97 |    0.74 | 0.0062 |   2,796 B |     104 B |        2.17 |
| Delegate   | net10 | net10     | 14.43 ns | 0.703 ns | 2.051 ns | 13.985 ns |  1.28 |    0.31 | 0.0029 |      51 B |      48 B |        1.00 |
| Accessor   | net10 | net10     | 10.54 ns | 0.707 ns | 2.061 ns |  9.545 ns |  0.94 |    0.26 | 0.0029 |   1,808 B |      48 B |        1.00 |
| Direct     | net8  | net8      | 15.97 ns | 0.615 ns | 1.723 ns | 15.476 ns |  1.42 |    0.31 | 0.0029 |     688 B |      48 B |        1.00 |
| Reflection | net8  | net8      | 40.52 ns | 1.839 ns | 5.247 ns | 38.606 ns |  3.60 |    0.83 | 0.0062 |   1,037 B |     104 B |        2.17 |
| Delegate   | net8  | net8      | 18.33 ns | 0.660 ns | 1.905 ns | 17.739 ns |  1.63 |    0.35 | 0.0029 |      51 B |      48 B |        1.00 |
| Accessor   | net8  | net8      | 15.48 ns | 0.430 ns | 1.220 ns | 15.159 ns |  1.38 |    0.28 | 0.0029 |     688 B |      48 B |        1.00 |
| Direct     | net9  | net9      | 15.31 ns | 0.451 ns | 1.264 ns | 14.974 ns |  1.36 |    0.28 | 0.0029 |     680 B |      48 B |        1.00 |
| Reflection | net9  | net9      | 39.75 ns | 1.113 ns | 3.210 ns | 38.641 ns |  3.53 |    0.73 | 0.0062 |     987 B |     104 B |        2.17 |
| Delegate   | net9  | net9      | 16.50 ns | 0.551 ns | 1.564 ns | 16.021 ns |  1.47 |    0.31 | 0.0029 |      51 B |      48 B |        1.00 |
| Accessor   | net9  | net9      | 15.63 ns | 0.488 ns | 1.417 ns | 15.167 ns |  1.39 |    0.29 | 0.0029 |     680 B |      48 B |        1.00 |
