using System;

namespace Listing_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 20, 1, 6, 15};

            // Print out array
            foreach (int i in test)
                Console.WriteLine(i);

            // Sorting
            Console.WriteLine("Sorted array");
            Array.Sort(test);
            foreach (int i in test)
                Console.WriteLine(i);

            // Reverse
            Console.WriteLine("Reversed array");
            Array.Reverse(test);
            foreach (int i in test)
                Console.WriteLine(i);

            // Deleting two items
            Console.WriteLine("Length before clear off {0}", test.Length);
            Array.Clear(test, 2, 2);
            Console.WriteLine("Length after clear off {0}", test.Length);
            foreach (int i in test)
                Console.WriteLine(i);
        }
    }
}
