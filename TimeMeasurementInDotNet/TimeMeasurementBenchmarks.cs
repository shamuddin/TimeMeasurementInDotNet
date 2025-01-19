using BenchmarkDotNet.Attributes; // Import for BenchmarkDotNet attributes
using System.Diagnostics;

[MarkdownExporter] // Export results to Markdown for easy sharing
[HtmlExporter]     // Export results to HTML for better visualization
[MemoryDiagnoser]  // Adds memory allocation statistics in the benchmark results
public class TimeMeasurementBenchmarks
{
    // A helper method to simulate an operation for measurement
    private async Task SimulateOperation()
    {
        // Introduce a 500ms delay to mimic a real operation
        await Task.Delay(500);
    }

    [Benchmark]
    public async Task MeasureWithDateTime()
    {
        // PROBLEM 1: Using DateTime.UtcNow for measuring execution time
        // Capture the start time
        var start = DateTime.UtcNow;

        // Simulate the operation
        await SimulateOperation();

        // Calculate the elapsed time
        var elapsed = DateTime.UtcNow - start;

        // This approach is problematic due to DateTime.UtcNow's overhead
    }

    [Benchmark]
    public async Task MeasureWithStopwatchStartNew()
    {
        // PROBLEM 2: Using Stopwatch.StartNew for measuring execution time
        // Create a new Stopwatch instance and start it
        var stopwatch = Stopwatch.StartNew();

        // Simulate the operation
        await SimulateOperation();

        // Stop the stopwatch
        stopwatch.Stop();

        // This approach works but allocates memory on the heap unnecessarily
    }

    [Benchmark]
    public async Task MeasureWithStopwatchGetTimestamp()
    {
        // SOLUTION: Using Stopwatch.GetTimestamp for measuring execution time
        // Capture the starting timestamp
        long startTimestamp = Stopwatch.GetTimestamp();

        // Simulate the operation
        await SimulateOperation();

        // Calculate the elapsed time using Stopwatch.GetElapsedTime
        TimeSpan elapsed = Stopwatch.GetElapsedTime(startTimestamp);

        // This is the most efficient and accurate way to measure execution time
    }
}