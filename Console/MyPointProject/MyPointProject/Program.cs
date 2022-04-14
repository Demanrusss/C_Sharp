using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(10, 20);
            MyPoint p2 = new MyPoint(20, 10);
            MyPoint p3 = p1 + p2;

            Console.WriteLine("MyPoint p1 " + p1.ToString());
            Console.WriteLine("MyPoint p2 " + p2.ToString());
            Console.WriteLine("MyPoint p3 " + p3.ToString());
        }
    }
}
