using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateProject
{
    internal class Program
    {
        public delegate int Factorial(int number);

        static void Main(string[] args)
        {
            Factorial fact_delegate = new Factorial(FactorialFunc);
            IAsyncResult result = fact_delegate.BeginInvoke(10, new AsyncCallback(CallBack), "This is a parameter");

            Console.WriteLine("You can write something here:");
            Console.ReadLine();

            // Wait for the result of delegate working
            int fact = fact_delegate.EndInvoke(result);
            Console.WriteLine($"Result: {fact}");
        }

        // Method which is working in a child stream
        public static int FactorialFunc(int number)
        {
            int fact = 1;
            for (int i = 2; i < number; i++)
            {
                fact *= i;
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Result from the child stream: {fact}");
            return fact;
        }

        private static void CallBack(IAsyncResult asyncResult)
        {
            string s = (string)asyncResult.AsyncState;
            Console.WriteLine("Async method has finished");
            Console.WriteLine($"The result is: {s}");
        }
    }
}
