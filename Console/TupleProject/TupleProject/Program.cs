using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleProject
{
    internal class Program
    {
        // Learning how to use Tuple (in Russian Kortezh)

        static void Main(string[] args)
        {
            Tuple<int, int> coordinates = new Tuple<int, int>(10, 20);
            Console.WriteLine(coordinates.Item1 + " " + coordinates.Item2);

            var coordinates2 = GetCoordinates();
            Console.WriteLine(coordinates2.Item1 + " " + coordinates2.Item2
                + " " + coordinates2.Item3 + " " + coordinates2.Item4);
        }

        static Tuple<int, int, int, string> GetCoordinates()
        {
            return new Tuple<int, int, int, string>(10, 20, 30, "Something");
        }
    }
}
