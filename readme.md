# Jolly.Vigesimal

A simple implementation of a Vigesimal type (base-20).

Further information on Vigesimal: [https://en.wikipedia.org/wiki/Vigesimal](https://en.wikipedia.org/wiki/Vigesimal)

This is a playground for me to experiment with simple optimisation strategies to reduce time/allocations, so PRs welcome if anyone sees the opportunity for improvements.

## Benchmarks

### Construct from decimal

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-KHYZXG : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-GXJRVE : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

IterationCount=10

|           Method | RunStrategy | UnrollFactor | IntValue |          Mean |            Error |           StdDev |      Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |------------ |------------- |--------- |--------------:|-----------------:|-----------------:|------------:|-------:|------:|------:|----------:|
| ConstructFromInt |   ColdStart |            1 |        1 | 719,720.00 ns | 3,400,794.968 ns | 2,249,415.308 ns | 5,250.00 ns |      - |     - |     - |      24 B |
| ConstructFromInt |  Throughput |           16 |        1 |      17.36 ns |         0.524 ns |         0.312 ns |    17.30 ns | 0.0153 |     - |     - |      24 B |
| ConstructFromInt |   ColdStart |            1 |      854 | 834,660.00 ns | 3,952,780.279 ns | 2,614,519.414 ns | 6,650.00 ns |      - |     - |     - |     136 B |
| ConstructFromInt |  Throughput |           16 |      854 |      92.05 ns |         5.437 ns |         3.596 ns |    91.56 ns | 0.0867 |     - |     - |     136 B |

### Construct from string

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-KHYZXG : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  Job-GXJRVE : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT

IterationCount=10

|              Method | RunStrategy | UnrollFactor | StringValue |          Mean |            Error |           StdDev |      Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |------------ |------------- |------------ |--------------:|-----------------:|-----------------:|------------:|------:|------:|------:|----------:|
| ConstructFromString |   ColdStart |            1 |         22E | 987,060.00 ns | 4,711,663.751 ns | 3,116,473.843 ns | 1,550.00 ns |     - |     - |     - |         - |
| ConstructFromString |  Throughput |           16 |         22E |      41.18 ns |         1.261 ns |         0.834 ns |    40.99 ns |     - |     - |     - |         - |
| ConstructFromString |   ColdStart |            1 |          A2 | 851,600.00 ns | 4,066,272.419 ns | 2,689,587.438 ns | 1,050.00 ns |     - |     - |     - |         - |
| ConstructFromString |  Throughput |           16 |          A2 |      37.56 ns |         5.913 ns |         3.911 ns |    37.78 ns |     - |     - |     - |         - |
