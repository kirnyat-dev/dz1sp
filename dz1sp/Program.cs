namespace dz1sp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(NotepadTask.Run);

            thread1.Start();
            thread1.Join();

            Thread thread2 = new Thread(CmdTask.Run);
            thread2.Start();
            thread2.Join();

            Console.WriteLine("Все потоки завершены");
            Console.ReadLine();
        }
    }
}
