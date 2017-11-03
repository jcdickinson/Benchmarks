``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4800MQ CPU 2.70GHz (Haswell), ProcessorCount=8
Frequency=2630627 Hz, Resolution=380.1375 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                  Method |     Mean |     Error |    StdDev | Scaled |
 |------------------------ |---------:|----------:|----------:|-------:|
 |                  Unsafe | 79.98 ns | 1.4723 ns | 1.3772 ns |   1.00 |
 |    'Calls, No Inlining' | 40.34 ns | 0.1778 ns | 0.1576 ns |   0.50 |
 | 'Unrolled, No Inlining' | 12.19 ns | 0.0433 ns | 0.0384 ns |   0.15 |
 |       'Calls, Inlining' | 34.55 ns | 0.1372 ns | 0.1216 ns |   0.43 |
 |    'Unrolled, Inlining' | 12.22 ns | 0.0885 ns | 0.0785 ns |   0.15 |
