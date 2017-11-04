using BenchmarkDotNet.Attributes;

namespace ConsoleApp6
{
    public class CombineBench
    {
        private volatile int _counter;
        private int GetCounter() => _counter++;

        [Benchmark(Description = "8: Inlined")]
        public void Combine8_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "8: Non-Inlined")]
        public void Combine8_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "7: Inlined")]
        public void Combine7_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "7: Non-Inlined")]
        public void Combine7_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "6: Inlined")]
        public void Combine6_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "6: Non-Inlined")]
        public void Combine6_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "5: Inlined")]
        public void Combine5_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "5: Non-Inlined")]
        public void Combine5_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "4: Inlined")]
        public void Combine4_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "4: Non-Inlined")]
        public void Combine4_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "3: Inlined")]
        public void Combine3_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "3: Non-Inlined")]
        public void Combine3_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "2: Inlined")]
        public void Combine2_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "2: Non-Inlined")]
        public void Combine2_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Description = "1: Inlined")]
        public void Combine1_Inlined()
        {
            _counter = InlinedUnrolled.HashCode.Combine(
                GetCounter());
        }

        [Benchmark(Description = "1: Non-Inlined")]
        public void Combine1_NonInlined()
        {
            _counter = CombineNonInlinedUnrolled.HashCode.Combine(
                GetCounter());
        }

        [Benchmark(Description = "Add+ToHashCode: Inlined", OperationsPerInvoke = 8)]
        public void Add_Inlined()
        {
            var hc = new InlinedUnrolled.HashCode();
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            _counter = hc.ToHashCode();
        }

        [Benchmark(Description = "Add+ToHashCode: Non-Inlined", OperationsPerInvoke = 8)]
        public void Add_NonInlined()
        {
            var hc = new CombineNonInlinedUnrolled.HashCode();
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            hc.Add(_counter);
            _counter = hc.ToHashCode();
        }

        [Benchmark(Description = "ToHashCode: Inlined")]
        public void ToHashCode_Inlined()
        {
            var hc = new InlinedUnrolled.HashCode();
            _counter = hc.ToHashCode();
        }

        [Benchmark(Description = "ToHashCode: Non-Inlined")]
        public void ToHashCode_NonInlined()
        {
            var hc = new CombineNonInlinedUnrolled.HashCode();
            _counter = hc.ToHashCode();
        }
    }
}
