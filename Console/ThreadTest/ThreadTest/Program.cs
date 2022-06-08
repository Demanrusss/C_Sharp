using System;
using System.Threading;

namespace ThreadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadProc));
            // Just not to wait the end of the child stream
            //t.IsBackground = true;
            t.Start();
            string s;

            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (s != "q");
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is a stream");
                Thread.Sleep(1000);
            }
        }
    }
}
