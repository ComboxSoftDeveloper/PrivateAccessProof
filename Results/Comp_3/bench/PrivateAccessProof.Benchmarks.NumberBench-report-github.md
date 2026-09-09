```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method     | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio  | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|----------- |------ |---------- |-----------:|----------:|----------:|-------:|--------:|-------:|----------:|----------:|------------:|
| Direct     | net10 | net10     |  0.4634 ns | 0.0181 ns | 0.0161 ns |   1.00 |    0.05 |      - |      14 B |         - |          NA |
| Reflection | net10 | net10     | 11.7065 ns | 0.2063 ns | 0.1829 ns |  25.29 |    0.91 | 0.0024 |   2,083 B |      24 B |          NA |
| Accessor   | net10 | net10     |  0.4826 ns | 0.0166 ns | 0.0130 ns |   1.04 |    0.04 |      - |      14 B |         - |          NA |
| Direct     | net8  | net8      |  0.4647 ns | 0.0126 ns | 0.0111 ns |   1.00 |    0.04 |      - |      14 B |         - |          NA |
| Reflection | net8  | net8      | 46.3849 ns | 0.5591 ns | 0.4956 ns | 100.21 |    3.41 | 0.0024 |     723 B |      24 B |          NA |
| Accessor   | net8  | net8      |  0.4754 ns | 0.0174 ns | 0.0154 ns |   1.03 |    0.05 |      - |      14 B |         - |          NA |
| Direct     | net9  | net9      |  0.4600 ns | 0.0257 ns | 0.0240 ns |   0.99 |    0.06 |      - |      14 B |         - |          NA |
| Reflection | net9  | net9      | 38.3732 ns | 0.2896 ns | 0.2419 ns |  82.90 |    2.74 | 0.0024 |   1,342 B |      24 B |          NA |
| Accessor   | net9  | net9      |  0.4522 ns | 0.0074 ns | 0.0062 ns |   0.98 |    0.03 |      - |      14 B |         - |          NA |
