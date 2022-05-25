using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter some integer: ");

                string inLine = Console.ReadLine();
                if (inLine == "q")
                    break;
                try
                {
                    int i = Convert.ToInt32(inLine);
                    Console.WriteLine($"You have entered: {i}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"You have entered the incorrect number {inLine}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
