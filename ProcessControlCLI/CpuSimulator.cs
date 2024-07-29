using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessControlCLI
{
    public static class CpuSimulator
    {
        public static async Task ConsumeCpuAsync(int percentage, CancellationToken token)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentException("Percentage must be between 0 and 100.");
            }

            Console.WriteLine($"Consuming {percentage}% CPU...");

            Stopwatch watch = new();
            watch.Start();

            while (!token.IsCancellationRequested)
            {
                if (watch.ElapsedMilliseconds > percentage)
                {
                    await Task.Delay(100 - percentage, token);
                    watch.Reset();
                    watch.Start();
                }
            }

            Console.WriteLine("CPU consumption stopped.");
        }
    }
}
