using System;

namespace PropertiesInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Michail";
            person.LastName = "Flenov";
            person.City = "Toronto";
            person.Country = "Canada";

            Console.WriteLine(person.LastName + " " + person.FirstName + " " + 
                              person.City + " " + person.Country);

            Person person1 = new Person()
            {
                FirstName = "Dmitriy",
                LastName = "Yevchenko",
                City = "Winnipeg",
                Country = "Canada"
            };

            Console.WriteLine(person1.LastName + " " + person1.FirstName + " " +
                              person1.City + " " + person1.Country);
        }
    }
}
