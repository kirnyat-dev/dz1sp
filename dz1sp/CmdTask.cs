using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1sp
{
    public class CmdTask
    {
        public static void Run()
        {
            Console.WriteLine("[Поток 2] Запуск потока");
            Console.WriteLine("[Поток 2] Запуск cmd.exe и отправка команды dir");

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c dir",
                RedirectStandardOutput = true
            };

            Process cmd = Process.Start(psi);

            string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();

            Console.WriteLine("[Поток 2] Результат команды dir:");
            Console.WriteLine(output);

            Console.WriteLine("[Поток 2] Поток завершён");
        }
    }
}
