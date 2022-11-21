using System.Diagnostics;

namespace Common
{
    public static class RunTime
    {
        public static void Show(Action method)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            method();

            stopwatch.Stop();
            Console.WriteLine($"The running time of this method: {method.Method} is {stopwatch.ElapsedMilliseconds} ms.");
        }

        public static void Show(Func<int, string> method, int parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            var st = method(parameter);

            stopwatch.Stop();
            Console.WriteLine($"The running time of this method: {method.Method} is {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}