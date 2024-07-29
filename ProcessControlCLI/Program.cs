namespace ProcessControlCLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowUsage();
                return;
            }

            string command = args[0].ToLower();
            CancellationTokenSource cts = new();

            try
            {
                switch (command)
                {
                    case "cpu":
                        if (args.Length != 2 || !int.TryParse(args[1], out int cpuPercentage))
                        {
                            Console.WriteLine("Usage: ProcessControlCLI cpu <percentage>");
                        }
                        else
                        {
                            await CpuSimulator.ConsumeCpuAsync(cpuPercentage, cts.Token);
                        }
                        break;

                    case "memory":
                        if (args.Length != 2 || !int.TryParse(args[1], out int memoryValue))
                        {
                            Console.WriteLine("Usage: ProcessControlCLI memory <value_in_mb>");
                        }
                        else
                        {
                            MemorySimulator.ConsumeMemory(memoryValue);
                        }
                        break;

                    case "crash":
                        ProcessManager.CrashProcess();
                        break;

                    case "restart":
                        ProcessManager.RestartProcess();
                        break;

                    default:
                        ShowUsage();
                        break;
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation canceled.");
            }
        }

        static void ShowUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  ProcessControlCLI cpu <percentage>");
            Console.WriteLine("  ProcessControlCLI memory <value_in_mb>");
            Console.WriteLine("  ProcessControlCLI crash");
            Console.WriteLine("  ProcessControlCLI restart");
        }
    }
}
