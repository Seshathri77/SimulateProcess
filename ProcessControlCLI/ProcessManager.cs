using System;
using System.Diagnostics;

namespace ProcessControlCLI
{
    public static class ProcessManager
    {
        private static Process process;

        public static void CrashProcess()
        {
            Console.WriteLine("Crashing the process...");
            Environment.Exit(-1);
        }

        public static void RestartProcess()
        {
            Console.WriteLine("Restarting the process...");

            if (process != null && !process.HasExited)
            {
                process.Kill();
            }

            process = Process.Start(new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                UseShellExecute = true
            });

            Console.WriteLine("Process restarted.");
        }
    }
}
