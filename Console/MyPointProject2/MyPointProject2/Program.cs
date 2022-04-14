using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(10, 20);
            MyPoint p2 = new MyPoint(20, 40);

            Console.WriteLine("MyPoint p1 {0} MyPoint p2", p1 < p2 ? "<" : ">");
        }
    }
}
