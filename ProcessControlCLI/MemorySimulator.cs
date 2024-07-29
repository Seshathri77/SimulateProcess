using System;

namespace ProcessControlCLI
{
    public static class MemorySimulator
    {
        public static void ConsumeMemory(int valueInMb)
        {
            if (valueInMb < 0)
            {
                throw new ArgumentException("Memory value must be a positive integer.");
            }

            Console.WriteLine($"Consuming {valueInMb} MB of memory...");

            byte[][] memory = new byte[valueInMb][];
            for (int i = 0; i < valueInMb; i++)
            {
                memory[i] = new byte[1024 * 1024];
            }

            Console.WriteLine("Memory consumption completed.");
            Console.ReadLine(); // Keep the memory allocated until user intervention
        }
    }
}
