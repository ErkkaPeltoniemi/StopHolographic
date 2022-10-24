using System;
using System.Diagnostics;

namespace HolographicStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "logman";
            startInfo.Arguments = "stop HolographicShell -ets";

            var process = new Process();
            process.StartInfo = startInfo;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
