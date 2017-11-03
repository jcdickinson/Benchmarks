using BenchmarkDotNet.Attributes;

namespace ConsoleApp6
{
    public class HashCodeBench
    {
        private volatile int _counter;
        private int GetCounter() => _counter++;

        [Benchmark(Baseline = true, Description = "Unsafe")]
        public void Unsafe()
        {
            ConsoleApp6.Unsafe.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Calls, No Inlining")]
        public void NonInlinedCalls()
        {
            ConsoleApp6.NonInlinedCalls.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Unrolled, No Inlining")]
        public void NonInlinedUnrolled()
        {
            ConsoleApp6.NonInlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Calls, Inlining")]
        public void InlinedCalls()
        {
            ConsoleApp6.InlinedCalls.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Unrolled, Inlining")]
        public void InlinedUnrolled()
        {
            ConsoleApp6.InlinedUnrolled.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }
    }
}
