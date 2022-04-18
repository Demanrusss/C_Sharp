using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Michail",
                Surname = "Flenov",
                X = 20,
                Y = 20,
                PointName = "Toronto"
            };

            Person person1 = new Person()
            {
                Name = "Dmitriy",
                Surname = "Yevchenko",
                X = 30,
                Y = 30,
                PointName = "Markham"
            };

            MyPoint point = (MyPoint)person;
            MyPoint point1 = (MyPoint)person1;

            Console.WriteLine("Object of Class Person: " + person.ToString());
            Console.WriteLine("Object of Class MyPoint: " + point.ToString());

            Console.WriteLine("Object of Class Person: " + person1.ToString());
            Console.WriteLine("Object of Class MyPoint: " + point1.ToString());
        }
    }
}
