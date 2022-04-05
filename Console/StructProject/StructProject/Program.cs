using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProject
{
    internal class Program
    {
        struct Person
        {
            public string FirstName;
            public string LastName;
            public int age;

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
                age = 18;
            }
        }

        static void Main(string[] args)
        {
            Person p;
            p.FirstName = "Sergei";
            Console.WriteLine(p.FirstName);

            Person p1 = new Person();
            Console.WriteLine("Lastname 1: " + p1.LastName);

            Person p2 = new Person("Michail", "Flenov");
            Console.WriteLine("Lastname 2: " + p2.LastName);
        }
    }
}
