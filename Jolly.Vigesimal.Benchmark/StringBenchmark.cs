using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Jolly.Vigesimal.Benchmark
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 10)]
    [SimpleJob(RunStrategy.Throughput, targetCount: 10)]
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        [Params("A2","22E")]
        public string StringValue { get; set; }

        [Benchmark]
        public void ConstructFromString()
        {
            var x = new Vigesimal(StringValue);
        }
    }
}