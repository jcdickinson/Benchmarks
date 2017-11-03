using BenchmarkDotNet.Running;
using ConsoleApp6.InlinedCalls;
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary1 = BenchmarkRunner.Run<BenchSafeVsUnsafe>();
            var summary2 = BenchmarkRunner.Run<HashCodeBench>();
        }
    }
}
