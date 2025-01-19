using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Benchmarks...");
        BenchmarkRunner.Run<TimeMeasurementBenchmarks>();
    }
}
