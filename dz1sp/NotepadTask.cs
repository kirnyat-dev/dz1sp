using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1sp
{
    public class NotepadTask
    {
        public static void Run()
        {
            Console.WriteLine("[Поток 1] Запуск потока");
            Console.WriteLine("[Поток 1] Запуск Notepad");

            Process notepad = Process.Start("notepad.exe");

            Console.WriteLine("[Поток 1] Ожидание завершения Notepad...");
            Thread.Sleep(3000);

            if (!notepad.HasExited)
            {
                notepad.Kill();
                Console.WriteLine("[Поток 1] Notepad закрыт");
            }

            Console.WriteLine("[Поток 1] Поток завершён");
        }
    }
}
