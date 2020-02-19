using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Jolly.Vigesimal.Benchmark
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 10)]
    [SimpleJob(RunStrategy.Throughput, targetCount: 10)]
    [MemoryDiagnoser]
    public class VigesimalBenchmark
    {
        [Benchmark]
        public void ConstructFromInt()
        {
            var x = new Vigesimal(1);
        }

        [Benchmark]
        public void ConstructFromString()
        {
            var x = new Vigesimal("A2");
        }

        [Benchmark]
        public void ConstructFromIntBigNumber()
        {
            var x = new Vigesimal(854);
        }

        [Benchmark]
        public void ConstructFromStringBigNumber()
        {
            var x = new Vigesimal("22E");
        }
    }
}