``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4800MQ CPU 2.70GHz (Haswell), ProcessorCount=8
Frequency=2630632 Hz, Resolution=380.1368 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                        Method |      Mean |     Error |    StdDev |
 |------------------------------ |----------:|----------:|----------:|
 |                  '8: Inlined' | 19.839 ns | 0.0479 ns | 0.0448 ns |
 |              '8: Non-Inlined' | 20.943 ns | 0.0436 ns | 0.0387 ns |
 |                  '7: Inlined' | 17.692 ns | 0.0428 ns | 0.0401 ns |
 |              '7: Non-Inlined' | 17.915 ns | 0.0650 ns | 0.0576 ns |
 |                  '6: Inlined' | 15.888 ns | 0.0779 ns | 0.0690 ns |
 |              '6: Non-Inlined' | 15.759 ns | 0.0501 ns | 0.0418 ns |
 |                  '5: Inlined' | 14.412 ns | 0.0553 ns | 0.0517 ns |
 |              '5: Non-Inlined' | 14.040 ns | 0.0755 ns | 0.0706 ns |
 |                  '4: Inlined' | 12.126 ns | 0.0358 ns | 0.0335 ns |
 |              '4: Non-Inlined' | 12.243 ns | 0.0653 ns | 0.0610 ns |
 |                  '3: Inlined' |  9.739 ns | 0.0314 ns | 0.0294 ns |
 |              '3: Non-Inlined' |  9.489 ns | 0.0100 ns | 0.0084 ns |
 |                  '2: Inlined' |  7.729 ns | 0.0225 ns | 0.0210 ns |
 |              '2: Non-Inlined' |  7.567 ns | 0.0185 ns | 0.0174 ns |
 |                  '1: Inlined' |  5.540 ns | 0.0149 ns | 0.0132 ns |
 |              '1: Non-Inlined' |  5.712 ns | 0.0197 ns | 0.0184 ns |
 |     'Add+ToHashCode: Inlined' | 30.280 ns | 0.1552 ns | 0.1452 ns |
 | 'Add+ToHashCode: Non-Inlined' | 38.465 ns | 0.1351 ns | 0.1198 ns |
 |         'ToHashCode: Inlined' | 10.160 ns | 0.0360 ns | 0.0337 ns |
 |     'ToHashCode: Non-Inlined' | 10.144 ns | 0.0194 ns | 0.0172 ns |
