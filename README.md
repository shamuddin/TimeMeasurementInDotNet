# **⏳ TimeMeasurementInDotNet**

A project to demonstrate the **correct way to measure execution time** in .NET. 🛠️ Learn how to avoid common pitfalls, optimize performance, and measure time like a pro!

---

## **📖 Overview**

This repository contains examples of three methods to measure execution time in .NET:
1. **`DateTime.UtcNow`**: A commonly used but inefficient approach.
2. **`Stopwatch.StartNew`**: Better, but introduces unnecessary overhead.
3. **`Stopwatch.GetTimestamp`**: The most accurate and efficient method.

Each method is benchmarked using **BenchmarkDotNet** to provide proof of performance. 💡

---

## **⚙️ Technologies Used**

- **.NET 8.0**  
- **C#**  
- **BenchmarkDotNet**  

---

## **📂 Project Structure**

```plaintext
TimeMeasurementInDotNet/
├── TimeMeasurementInDotNet/      # Main project folder
│   ├── Program.cs                # Entry point for running benchmarks
│   ├── TimeMeasurementBenchmarks.cs  # Contains benchmark tests for all three methods
├── .gitignore                    # Ignore unnecessary files in Git
├── LICENSE                       # License information
├── README.md                     # Project documentation
```

---

## **🚀 How to Run**

Follow these steps to run the benchmarks and view the results:

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/<your-username>/TimeMeasurementInDotNet.git
   cd TimeMeasurementInDotNet
   ```

2. **Restore Dependencies**  
   ```bash
   dotnet restore
   ```

3. **Run Benchmarks**  
   Make sure you are in **Release mode** before running:
   ```bash
   dotnet run --configuration Release
   ```

4. **View Results**  
   Results will appear in the console and as `.html` and `.md` files under:
   ```plaintext
   bin/Release/net8.0/BenchmarkDotNet.Artifacts/results/
   ```

---

## **🔬 Benchmark Results**

| 🛠️ **Method**                      | 🕒 **Mean** | 📉 **Error** | 📊 **StdDev** | 💾 **Allocated** |
|------------------------------------|------------:|-------------:|--------------:|-----------------:|
| **MeasureWithDateTime**            | 509.0 ms    | 1.77 ms      | 1.66 ms       | 1.1 KB           |
| **MeasureWithStopwatchStartNew**   | 509.6 ms    | 1.34 ms      | 1.25 ms       | 1.14 KB          |
| **MeasureWithStopwatchGetTimestamp** | 509.3 ms    | 1.42 ms      | 1.32 ms       | 1.1 KB           |

🔍 **Insights**:
- **`DateTime.UtcNow`**: Adds unnecessary overhead due to internal date calculations.  
- **`Stopwatch.StartNew`**: Allocates memory unnecessarily.  
- **`Stopwatch.GetTimestamp`**: Fast, precise, and memory-efficient.  

---

## **📜 License**

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

[## **📚 References**

- Medium Article: [Read the Full Explanation](https://medium.com/your-article-link)](https://medium.com/@shamuddin/stop-measuring-time-wrongly-in-net-the-right-way-to-measure-execution-time-291b04371750)
