```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     | 14.05 ns | 0.290 ns | 0.272 ns |  1.00 |    0.03 | 0.0048 |   1,588 B |      48 B |        1.00 |
| Reflection | net10 | net10     | 40.27 ns | 0.795 ns | 0.816 ns |  2.87 |    0.08 | 0.0103 |   2,804 B |     104 B |        2.17 |
| Delegate   | net10 | net10     | 16.12 ns | 0.267 ns | 0.237 ns |  1.15 |    0.03 | 0.0048 |      51 B |      48 B |        1.00 |
| Accessor   | net10 | net10     | 13.95 ns | 0.237 ns | 0.210 ns |  0.99 |    0.02 | 0.0048 |   1,588 B |      48 B |        1.00 |
| Direct     | net8  | net8      | 20.09 ns | 0.454 ns | 0.466 ns |  1.43 |    0.04 | 0.0048 |     688 B |      48 B |        1.00 |
| Reflection | net8  | net8      | 48.63 ns | 0.788 ns | 0.699 ns |  3.46 |    0.08 | 0.0103 |   1,037 B |     104 B |        2.17 |
| Delegate   | net8  | net8      | 22.06 ns | 0.493 ns | 0.624 ns |  1.57 |    0.05 | 0.0048 |      51 B |      48 B |        1.00 |
| Accessor   | net8  | net8      | 21.12 ns | 0.483 ns | 0.919 ns |  1.50 |    0.07 | 0.0048 |     688 B |      48 B |        1.00 |
| Direct     | net9  | net9      | 19.60 ns | 0.441 ns | 0.490 ns |  1.39 |    0.04 | 0.0048 |     680 B |      48 B |        1.00 |
| Reflection | net9  | net9      | 44.69 ns | 0.479 ns | 0.400 ns |  3.18 |    0.07 | 0.0103 |     980 B |     104 B |        2.17 |
| Delegate   | net9  | net9      | 21.25 ns | 0.452 ns | 0.603 ns |  1.51 |    0.05 | 0.0048 |      51 B |      48 B |        1.00 |
| Accessor   | net9  | net9      | 19.08 ns | 0.418 ns | 0.465 ns |  1.36 |    0.04 | 0.0048 |     680 B |      48 B |        1.00 |
