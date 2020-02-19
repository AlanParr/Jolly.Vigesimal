using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Jolly.Vigesimal.Benchmark
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 10)]
    [SimpleJob(RunStrategy.Throughput, targetCount: 10)]
    [MemoryDiagnoser]
    public class IntBenchmark
    {
        [Params(1,854)]
        public int IntValue { get; set; }

        [Benchmark]
        public void ConstructFromInt()
        {
            var x = new Vigesimal(IntValue);
        }
    }
}