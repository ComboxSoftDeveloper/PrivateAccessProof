```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Reflection | net10 | net10     |  9.730 ns | 0.1122 ns | 0.0937 ns |  1.00 |    0.01 |   2,468 B |         - |          NA |
| Expression | net10 | net10     |  3.257 ns | 0.0785 ns | 0.0734 ns |  0.33 |    0.01 |      56 B |         - |          NA |
| Emit       | net10 | net10     |  4.302 ns | 0.0565 ns | 0.0529 ns |  0.44 |    0.01 |      56 B |         - |          NA |
| Accessor   | net10 | net10     |  1.993 ns | 0.0620 ns | 0.0609 ns |  0.20 |    0.01 |      31 B |         - |          NA |
| Reflection | net8  | net8      | 36.233 ns | 0.1358 ns | 0.1061 ns |  3.72 |    0.04 |     923 B |         - |          NA |
| Expression | net8  | net8      |  3.346 ns | 0.0796 ns | 0.0621 ns |  0.34 |    0.01 |      56 B |         - |          NA |
| Emit       | net8  | net8      |  4.381 ns | 0.0721 ns | 0.0602 ns |  0.45 |    0.01 |      56 B |         - |          NA |
| Accessor   | net8  | net8      |  2.228 ns | 0.0402 ns | 0.0376 ns |  0.23 |    0.00 |      31 B |         - |          NA |
| Reflection | net9  | net9      | 10.449 ns | 0.2296 ns | 0.2255 ns |  1.07 |    0.02 |   2,212 B |         - |          NA |
| Expression | net9  | net9      |  3.249 ns | 0.0322 ns | 0.0269 ns |  0.33 |    0.00 |      56 B |         - |          NA |
| Emit       | net9  | net9      |  4.301 ns | 0.0574 ns | 0.0509 ns |  0.44 |    0.01 |      56 B |         - |          NA |
| Accessor   | net9  | net9      |  2.195 ns | 0.0427 ns | 0.0378 ns |  0.23 |    0.00 |      31 B |         - |          NA |
