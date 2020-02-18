using BenchmarkDotNet.Running;
using Jolly.Vigesimal.Benchmark.Configs;
using System;

namespace Jolly.Vigesimal.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var bm = BenchmarkRunner.Run<VigesimalBenchmark>(new AllowNonOptimized());
            Console.ReadKey();
        }
    }
}
