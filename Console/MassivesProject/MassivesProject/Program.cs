using System;
using System.Collections.Generic;

namespace MassivesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            // Fill in the massive
            persons.Add(new Person("Ivan", "Ivanov"));
            persons.Add(new Person("Sergei", "Petrov"));
            persons.Add(new Person("Igor", "Sidorov"));

            // Changing the name of list[0]
            persons[0].FirstName = "New name";

            // Printing out the list
            foreach (Person person in persons)
                Console.WriteLine(person.FirstName + " " + person.LastName);

            Console.WriteLine();

            List<Object> persons2 = new List<Object>();

            // Fill in the massive
            persons2.Add(new Person("Igor", "Petrov"));
            persons2.Add(new Person("Andrei", "Ivanov"));
            persons2.Add(new Person("Petr", "Sidorov"));

            // Changing the name of list[0]
            ((Person)persons2[0]).FirstName = "Dif. name";

            // Printing out the list
            foreach (Person person2 in persons2)
                Console.WriteLine(person2.FirstName + " " + person2.LastName);
        }
    }
}
