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
 |                  '8: Inlined' | 20.109 ns | 0.0920 ns | 0.0861 ns |
 |              '8: Non-Inlined' | 21.524 ns | 0.0653 ns | 0.0611 ns |
 |                  '7: Inlined' | 17.914 ns | 0.0849 ns | 0.0794 ns |
 |              '7: Non-Inlined' | 18.091 ns | 0.1099 ns | 0.1028 ns |
 |                  '6: Inlined' | 16.357 ns | 0.0916 ns | 0.0812 ns |
 |              '6: Non-Inlined' | 16.282 ns | 0.1103 ns | 0.0921 ns |
 |                  '5: Inlined' | 14.554 ns | 0.0737 ns | 0.0689 ns |
 |              '5: Non-Inlined' | 14.169 ns | 0.0663 ns | 0.0620 ns |
 |                  '4: Inlined' | 12.550 ns | 0.0442 ns | 0.0369 ns |
 |              '4: Non-Inlined' | 12.684 ns | 0.0712 ns | 0.0666 ns |
 |                  '3: Inlined' |  9.789 ns | 0.0377 ns | 0.0334 ns |
 |              '3: Non-Inlined' |  9.519 ns | 0.0661 ns | 0.0618 ns |
 |                  '2: Inlined' |  7.736 ns | 0.0689 ns | 0.0644 ns |
 |              '2: Non-Inlined' |  7.547 ns | 0.0452 ns | 0.0423 ns |
 |                  '1: Inlined' |  5.796 ns | 0.0286 ns | 0.0224 ns |
 |              '1: Non-Inlined' |  5.678 ns | 0.0339 ns | 0.0317 ns |
 |     'Add+ToHashCode: Inlined' |  3.836 ns | 0.0346 ns | 0.0324 ns |
 | 'Add+ToHashCode: Non-Inlined' |  4.820 ns | 0.0286 ns | 0.0223 ns |
 |         'ToHashCode: Inlined' | 10.089 ns | 0.0388 ns | 0.0363 ns |
 |     'ToHashCode: Non-Inlined' | 10.091 ns | 0.0570 ns | 0.0534 ns |
