using System;

namespace EasyCSharp2
{
    public class Program
    {
        int sum = 1, max = 5;

        public static void Main()
        {
            int i = 2;

            do
            {
                sum *= i;
                i++;
            } while (i <= max);

            Console.WriteLine(sum);
        }
    }
}
