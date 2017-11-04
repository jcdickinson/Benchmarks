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
 |                  '8: Inlined' | 20.048 ns | 0.2160 ns | 0.2020 ns |
 |              '8: Non-Inlined' | 21.022 ns | 0.0514 ns | 0.0481 ns |
 |                  '7: Inlined' | 17.509 ns | 0.0710 ns | 0.0664 ns |
 |              '7: Non-Inlined' | 17.721 ns | 0.0430 ns | 0.0359 ns |
 |                  '6: Inlined' | 15.994 ns | 0.0405 ns | 0.0359 ns |
 |              '6: Non-Inlined' | 15.892 ns | 0.0726 ns | 0.0679 ns |
 |                  '5: Inlined' | 14.242 ns | 0.0475 ns | 0.0421 ns |
 |              '5: Non-Inlined' | 13.910 ns | 0.0765 ns | 0.0716 ns |
 |                  '4: Inlined' | 12.244 ns | 0.0269 ns | 0.0239 ns |
 |              '4: Non-Inlined' | 12.416 ns | 0.0228 ns | 0.0213 ns |
 |                  '3: Inlined' |  9.565 ns | 0.0577 ns | 0.0540 ns |
 |              '3: Non-Inlined' |  9.345 ns | 0.0476 ns | 0.0422 ns |
 |                  '2: Inlined' |  7.617 ns | 0.0270 ns | 0.0253 ns |
 |              '2: Non-Inlined' |  7.411 ns | 0.0242 ns | 0.0227 ns |
 |                  '1: Inlined' |  5.653 ns | 0.0246 ns | 0.0230 ns |
 |              '1: Non-Inlined' |  5.607 ns | 0.0115 ns | 0.0108 ns |
 |     'Add+ToHashCode: Inlined' | 30.009 ns | 0.0945 ns | 0.0884 ns |
 | 'Add+ToHashCode: Non-Inlined' | 37.874 ns | 0.1375 ns | 0.1219 ns |
