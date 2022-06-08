using System;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ConcurentAccess
{
    [Synchronization]
    internal class Program
    {
        private readonly static object _lock = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(new ThreadStart(ThreadFunc));
                t.Name = "Stream" + i.ToString();
                t.Start();
            }

            Console.ReadLine();
        }

        // Method which will be carried out in the stream
        private static void ThreadFunc()
        {
            lock (_lock)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "-" + i.ToString());
                    Thread.Sleep(100);
                }
            }
        }
    }
}
