``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4800MQ CPU 2.70GHz (Haswell), ProcessorCount=8
Frequency=2630632 Hz, Resolution=380.1368 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                  Method |     Mean |     Error |    StdDev | Scaled |
 |------------------------ |---------:|----------:|----------:|-------:|
 |                  Unsafe | 55.91 ns | 0.5293 ns | 0.4692 ns |   1.00 |
 |    'Calls, No Inlining' | 39.37 ns | 0.0902 ns | 0.0844 ns |   0.70 |
 | 'Unrolled, No Inlining' | 11.93 ns | 0.1219 ns | 0.1081 ns |   0.21 |
 |       'Calls, Inlining' | 30.42 ns | 0.0928 ns | 0.0823 ns |   0.54 |
 |    'Unrolled, Inlining' | 11.93 ns | 0.1003 ns | 0.0838 ns |   0.21 |
 |           'Seed Read 1' | 12.12 ns | 0.1618 ns | 0.1514 ns |   0.22 |
 |           'Seed Read 4' | 12.01 ns | 0.1978 ns | 0.1850 ns |   0.21 |
 |             'Seed Lazy' | 11.91 ns | 0.0165 ns | 0.0154 ns |   0.21 |
 |      'Seed Thread Lazy' | 13.85 ns | 0.0334 ns | 0.0261 ns |   0.25 |
