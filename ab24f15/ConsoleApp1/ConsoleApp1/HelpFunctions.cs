using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Game1
{
    class HelpFunctions
    {
        public static void NeedHelp()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            Process p = Process.Start(psi);

            StreamWriter sw = p.StandardInput;
            StreamReader sr = p.StandardOutput;

            sw.WriteLine("TESTING HELP");
        }
        public static void Test()
        {
            Console.WriteLine("Success!");
        }
    }
}
