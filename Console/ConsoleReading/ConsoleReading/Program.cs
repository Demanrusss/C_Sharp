using System;

namespace ConsoleReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            do
            {
                int x = Console.Read(); // Reading ongoing symbol
                ch = Convert.ToChar(x); // Convert to char type
                
                if (x != 10 && x != 13)
                    Console.WriteLine(ch);  // Print out the symbol on new line

            } while (ch != 'q');

            string str;

            do
            {
                str = Console.ReadLine();
                Console.WriteLine(str);
            } while (str != "q");
        }
    }
}
