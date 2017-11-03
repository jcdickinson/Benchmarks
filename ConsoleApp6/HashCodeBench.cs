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

        [Benchmark(Baseline = false, Description = "Seed Read 1")]
        public void SeedRead1()
        {
            ConsoleApp6.SeedRead1.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Seed Read 4")]
        public void SeedRead4()
        {
            ConsoleApp6.SeedRead4.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Seed Lazy")]
        public void SeedLazy()
        {
            ConsoleApp6.SeedLazy.HashCode.Combine(
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter(),
                GetCounter());
        }

        [Benchmark(Baseline = false, Description = "Seed Thread Lazy")]
        public void SeedThreadLazy()
        {
            ConsoleApp6.SeedThreadLazy.HashCode.Combine(
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
