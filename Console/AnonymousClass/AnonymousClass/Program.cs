using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If we have to make an Object without creating new Class
            // Just use anonymous Class with var or Object

            var p = new
            {
                FirstName = "Michail",
                LastName = "Flenov",
                Age = 10
            };

            var p2 = new
            {
                Name = "Dmitriy",
                Surname = "Yevchenko",
                Age = 20,
                City = "Markham"
            };

            Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Age.ToString());
            Console.WriteLine(p2.Name + " " + p2.Surname + " " + p2.Age + " " + p2.City);
        }
    }
}
