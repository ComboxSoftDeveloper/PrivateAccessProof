```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Reflection | net10 | net10     | 10.301 ns | 0.2282 ns | 0.2134 ns |  1.00 |    0.03 |   2,438 B |         - |          NA |
| Expression | net10 | net10     |  3.591 ns | 0.0793 ns | 0.0742 ns |  0.35 |    0.01 |      46 B |         - |          NA |
| Emit       | net10 | net10     |  5.283 ns | 0.1374 ns | 0.1970 ns |  0.51 |    0.02 |      46 B |         - |          NA |
| Accessor   | net10 | net10     |  2.459 ns | 0.0706 ns | 0.0661 ns |  0.24 |    0.01 |      26 B |         - |          NA |
| Reflection | net8  | net8      | 39.793 ns | 0.7626 ns | 0.7134 ns |  3.86 |    0.10 |     898 B |         - |          NA |
| Expression | net8  | net8      |  3.593 ns | 0.1114 ns | 0.1094 ns |  0.35 |    0.01 |      46 B |         - |          NA |
| Emit       | net8  | net8      |  5.142 ns | 0.0902 ns | 0.0799 ns |  0.50 |    0.01 |      46 B |         - |          NA |
| Accessor   | net8  | net8      |  2.637 ns | 0.0830 ns | 0.0956 ns |  0.26 |    0.01 |      26 B |         - |          NA |
| Reflection | net9  | net9      | 10.396 ns | 0.1836 ns | 0.1717 ns |  1.01 |    0.03 |   2,187 B |         - |          NA |
| Expression | net9  | net9      |  3.597 ns | 0.1068 ns | 0.1271 ns |  0.35 |    0.01 |      46 B |         - |          NA |
| Emit       | net9  | net9      |  5.131 ns | 0.0833 ns | 0.0779 ns |  0.50 |    0.01 |      46 B |         - |          NA |
| Accessor   | net9  | net9      |  2.563 ns | 0.0831 ns | 0.0816 ns |  0.25 |    0.01 |      26 B |         - |          NA |
