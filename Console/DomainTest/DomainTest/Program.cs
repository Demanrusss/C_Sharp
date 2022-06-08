using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is external build");
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            Console.ReadLine();
            Console.WriteLine("Shutting down the task");
        }
    }
}
