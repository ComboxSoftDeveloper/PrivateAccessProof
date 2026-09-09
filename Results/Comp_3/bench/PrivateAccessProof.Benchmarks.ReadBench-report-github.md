```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method           | Job   | Toolchain | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|----------------- |------ |---------- |-----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| Direct           | net10 | net10     |  0.9838 ns | 0.0155 ns | 0.0121 ns |  1.00 |    0.02 |      15 B |         - |          NA |
| ReflectionFresh  | net10 | net10     | 16.3642 ns | 0.2453 ns | 0.2175 ns | 16.64 |    0.29 |   1,734 B |         - |          NA |
| ReflectionCached | net10 | net10     |  2.9642 ns | 0.0211 ns | 0.0177 ns |  3.01 |    0.04 |   1,575 B |         - |          NA |
| Expression       | net10 | net10     |  2.2035 ns | 0.0228 ns | 0.0191 ns |  2.24 |    0.03 |      43 B |         - |          NA |
| Emit             | net10 | net10     |  3.1487 ns | 0.0427 ns | 0.0356 ns |  3.20 |    0.05 |      43 B |         - |          NA |
| Accessor         | net10 | net10     |  1.0182 ns | 0.0137 ns | 0.0114 ns |  1.04 |    0.02 |      15 B |         - |          NA |
| Direct           | net8  | net8      |  1.0742 ns | 0.0277 ns | 0.0231 ns |  1.09 |    0.03 |      15 B |         - |          NA |
| ReflectionFresh  | net8  | net8      | 46.3633 ns | 0.1390 ns | 0.1085 ns | 47.14 |    0.57 |     258 B |         - |          NA |
| ReflectionCached | net8  | net8      | 32.8776 ns | 0.3285 ns | 0.2912 ns | 33.43 |    0.49 |     772 B |         - |          NA |
| Expression       | net8  | net8      |  2.0002 ns | 0.0884 ns | 0.0784 ns |  2.03 |    0.08 |      43 B |         - |          NA |
| Emit             | net8  | net8      |  2.8253 ns | 0.0377 ns | 0.0334 ns |  2.87 |    0.05 |      43 B |         - |          NA |
| Accessor         | net8  | net8      |  0.9307 ns | 0.0274 ns | 0.0243 ns |  0.95 |    0.03 |      15 B |         - |          NA |
| Direct           | net9  | net9      |  0.9184 ns | 0.0199 ns | 0.0167 ns |  0.93 |    0.02 |      15 B |         - |          NA |
| ReflectionFresh  | net9  | net9      | 18.8712 ns | 0.4304 ns | 0.5123 ns | 19.19 |    0.56 |   1,491 B |         - |          NA |
| ReflectionCached | net9  | net9      |  4.0871 ns | 0.1327 ns | 0.1303 ns |  4.16 |    0.14 |   1,346 B |         - |          NA |
| Expression       | net9  | net9      |  1.7041 ns | 0.0288 ns | 0.0255 ns |  1.73 |    0.03 |      43 B |         - |          NA |
| Emit             | net9  | net9      |  2.7657 ns | 0.0806 ns | 0.0754 ns |  2.81 |    0.08 |      43 B |         - |          NA |
| Accessor         | net9  | net9      |  0.9346 ns | 0.0245 ns | 0.0217 ns |  0.95 |    0.02 |      15 B |         - |          NA |
