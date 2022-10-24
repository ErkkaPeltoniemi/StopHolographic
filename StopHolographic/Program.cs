using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopHolographic
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
            Console.ReadKey();

        }
    }
}
