```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     | 15.76 ns | 0.383 ns | 0.511 ns |  1.00 |    0.04 | 0.0038 |   1,552 B |      48 B |        1.00 |
| Reflection | net10 | net10     | 47.96 ns | 1.206 ns | 3.381 ns |  3.05 |    0.23 | 0.0083 |   2,783 B |     104 B |        2.17 |
| Delegate   | net10 | net10     | 20.65 ns | 0.480 ns | 1.064 ns |  1.31 |    0.08 | 0.0038 |      46 B |      48 B |        1.00 |
| Accessor   | net10 | net10     | 17.68 ns | 0.424 ns | 1.017 ns |  1.12 |    0.07 | 0.0038 |   1,747 B |      48 B |        1.00 |
| Direct     | net8  | net8      | 22.72 ns | 0.512 ns | 0.548 ns |  1.44 |    0.06 | 0.0038 |     668 B |      48 B |        1.00 |
| Reflection | net8  | net8      | 51.13 ns | 1.084 ns | 1.954 ns |  3.25 |    0.16 | 0.0083 |   1,032 B |     104 B |        2.17 |
| Delegate   | net8  | net8      | 23.64 ns | 0.545 ns | 0.816 ns |  1.50 |    0.07 | 0.0038 |      46 B |      48 B |        1.00 |
| Accessor   | net8  | net8      | 21.72 ns | 0.493 ns | 0.437 ns |  1.38 |    0.05 | 0.0038 |     668 B |      48 B |        1.00 |
| Direct     | net9  | net9      | 20.61 ns | 0.482 ns | 0.555 ns |  1.31 |    0.05 | 0.0038 |     661 B |      48 B |        1.00 |
| Reflection | net9  | net9      | 50.33 ns | 1.064 ns | 1.138 ns |  3.20 |    0.12 | 0.0083 |     962 B |     104 B |        2.17 |
| Delegate   | net9  | net9      | 24.70 ns | 0.570 ns | 0.969 ns |  1.57 |    0.08 | 0.0038 |      46 B |      48 B |        1.00 |
| Accessor   | net9  | net9      | 22.56 ns | 0.523 ns | 0.767 ns |  1.43 |    0.07 | 0.0038 |     661 B |      48 B |        1.00 |
