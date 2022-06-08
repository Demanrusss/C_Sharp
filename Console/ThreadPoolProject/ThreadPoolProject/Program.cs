using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaitCallback waitCallback = new WaitCallback(FactFunc);

            // A loop of including delegates to a que
            for (int i = 1; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(waitCallback, i);
            }

            Console.ReadLine();
        }

        // A delegate of calculating a factorial
        private static void FactFunc(object state)
        {
            int num = (int)state;
            int result = 1;

            for (int i = 2; i < num; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
