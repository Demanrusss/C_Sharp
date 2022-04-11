using System;

namespace WriteLineMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread costs = {0} rubles", 25);

            Console.WriteLine("String1\nString2");

            Console.WriteLine("Number1 is {0}\nNumber2 is {1}", 10, 12);

            Console.WriteLine(
                "First number is {0}\nSecond number is {1}\nAnd again first number is {0}", 
                new Object[] { 3, 4 }
                );

            Console.WriteLine("Bread costs = {0:c}", 25);
            Console.WriteLine("Bread costs = {0:c4}", 25);
            Console.WriteLine("Bread costs = {0:d5}", 25);
            Console.WriteLine("Bread costs = {0:f3}", 25.4);
            Console.WriteLine("Bread costs = {0:n}", 25000);
            Console.WriteLine("Bread costs = {0:e}", 25000);
            Console.WriteLine("Bread costs = {0:x}", 25000);
        }
    }
}
