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

            // method IndexOf()
            int index = strSource.IndexOf(strToSearch);
            if (index != -1)
                Console.WriteLine("Found at " + index);
            
            // method Insert()
            string strExample = strSource.Insert(5, "example");
            Console.WriteLine(strExample);

            //methods PadLeft(int N) and PadRight(int N)
            strExample = strSource.PadLeft(50);
            Console.WriteLine(strExample);
            strExample = strSource.PadRight(50);
            Console.WriteLine(strExample);

            // method Remove()
            strExample = strSource.Remove(5, 5);
            Console.WriteLine("After Remove " + strExample);

            //method Replace()
            strExample = strSource.Replace(strToSearch, "WORLD");
            Console.WriteLine("After Replace " + strExample);

            // method ToUpper() and ToLower()
            strExample = strSource.ToUpper();
            Console.WriteLine("ToUpper " + strExample);
            Console.WriteLine("ToLower " + strExample.ToLower());

            // metod Substring()
            strExample = strSource.Substring(5);
            Console.WriteLine("Substring after 5th symbol " + strExample);

            // method ToCharArray()
            char[] chars = strSource.ToCharArray();
            foreach (char symbol in chars)
                Console.Write(symbol + "\'");

            Console.WriteLine("\n");

            // check up a string for emptiness
            Console.WriteLine("Enter some sentence, I'll check it up for emptiness.");
            strSource = Console.ReadLine();

            // first option of realisation
            if (strSource == null || strSource == "")
                Console.WriteLine("Your entered nothing.");

            // second option of realisation by static method IsNullOrEmpty()
            if (String.IsNullOrEmpty(strSource))
                Console.WriteLine("Your entered nothing...");
        }
    }
}
