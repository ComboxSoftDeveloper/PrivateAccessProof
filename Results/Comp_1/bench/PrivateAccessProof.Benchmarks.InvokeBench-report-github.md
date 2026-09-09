```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method     | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     |  8.886 ns | 0.1924 ns | 0.2058 ns |  1.00 |    0.03 | 0.0046 |   1,588 B |      48 B |        1.00 |
| Reflection | net10 | net10     | 25.876 ns | 0.5407 ns | 0.5310 ns |  2.91 |    0.09 | 0.0099 |   2,796 B |     104 B |        2.17 |
| Delegate   | net10 | net10     | 11.463 ns | 0.2695 ns | 0.2767 ns |  1.29 |    0.04 | 0.0046 |      51 B |      48 B |        1.00 |
| Accessor   | net10 | net10     |  9.041 ns | 0.1941 ns | 0.1721 ns |  1.02 |    0.03 | 0.0046 |   1,588 B |      48 B |        1.00 |
| Direct     | net8  | net8      | 12.611 ns | 0.2950 ns | 0.4416 ns |  1.42 |    0.06 | 0.0046 |     688 B |      48 B |        1.00 |
| Reflection | net8  | net8      | 33.341 ns | 0.5098 ns | 0.4769 ns |  3.75 |    0.10 | 0.0099 |   1,037 B |     104 B |        2.17 |
| Delegate   | net8  | net8      | 13.903 ns | 0.1378 ns | 0.1151 ns |  1.57 |    0.04 | 0.0046 |      51 B |      48 B |        1.00 |
| Accessor   | net8  | net8      | 12.194 ns | 0.1620 ns | 0.1436 ns |  1.37 |    0.03 | 0.0046 |     688 B |      48 B |        1.00 |
| Direct     | net9  | net9      | 12.596 ns | 0.0707 ns | 0.0661 ns |  1.42 |    0.03 | 0.0046 |     680 B |      48 B |        1.00 |
| Reflection | net9  | net9      | 31.952 ns | 0.2236 ns | 0.2091 ns |  3.60 |    0.08 | 0.0099 |     987 B |     104 B |        2.17 |
| Delegate   | net9  | net9      | 14.646 ns | 0.3436 ns | 0.9288 ns |  1.65 |    0.11 | 0.0046 |      51 B |      48 B |        1.00 |
| Accessor   | net9  | net9      | 14.010 ns | 0.3304 ns | 0.6365 ns |  1.58 |    0.08 | 0.0046 |     680 B |      48 B |        1.00 |
