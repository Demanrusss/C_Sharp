using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strSource, strToSearch;

            Console.WriteLine("Enter one string: ");
            strSource = Console.ReadLine();
            Console.WriteLine("Enter second string for searching: ");
            strToSearch = Console.ReadLine();

            // method Contains()
            if (strSource.Contains(strToSearch))
                Console.WriteLine("String1 contains string2");

            // static method Format()
            String strOfClassString;
            strOfClassString = String.Format("Hello {0} and let's get the {1} rolling!",
                "world", "ball");
            Console.WriteLine(strOfClassString);
        }
    }
}
