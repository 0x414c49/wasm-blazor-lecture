using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using WebAssembly;
using WebAssembly.Net.Http.HttpClient;
using System.Diagnostics;
using System.Threading.Tasks;

public class Codes
{
    public static void Main()
    {
        Console.WriteLine(Run());        
    }
    private static void GenerateGuids()
    {
        for (var i = 0; i < 10000; i++)
        {
            var guid = new Guid();
            Console.WriteLine(guid);
        }
    }

    private static void Sum()
    {
        var result = 0d;
        while (result < double.MaxValue)
            result += 10; ;
    }

    private static void Sort()
    {
        var array = new int[100000];
        var index = 100000 - 1;
        var counter = 0;
        while (index > 0)
            array[index--] = counter++;

        Array.Sort(array);
    }

    private static TimeSpan[] Benchmark(Action action, int times = 1)
    {
        var results = new TimeSpan[times];

        for (var i = 0; i < times; i++)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            action?.Invoke();
            stopWatch.Stop();
            results[i] = stopWatch.Elapsed;
        }

        return results;
    }
    
    public async static Task<string> Run()
    {
        var times = 3;
        var sb = new StringBuilder();

        sb.AppendLine($"Running method for {times}: times");

        var sortBenchmark = Benchmark( () => Sort(), times);

        foreach (var ts in sortBenchmark)
        {
            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            sb.AppendLine(elapsedTime);
        }

        return await Task.FromResult(sb.ToString());
    }
}
