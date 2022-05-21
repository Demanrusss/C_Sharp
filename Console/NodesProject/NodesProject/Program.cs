using System;
using System.Collections;

namespace NodesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Learning how to use the Collection Queue
            Queue queue = new Queue();

            for (int i = 0; i <= 10; i++)
            {
                queue.Enqueue($"Item number {i}");
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine();

            // Learning how to use the Collection Stack
            Stack stack = new Stack();

            for (int i = 0; i <= 10; i++)
            {
                stack.Push($"Item number {i} in stack");
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // Learning how to use Hashtable
            Hashtable hash = new Hashtable();

            hash.Add("Michail Smirnov", new Person("Michail", "Smirnov"));
            hash.Add("Andrei Smirnov", new Person("Andrei", "Smirnov"));
            hash.Add("Kirill Abramov", new Person("Kirill", "Abramov"));

            Console.WriteLine("Values:");
            foreach (Person person in hash.Values)
            {
                Console.WriteLine(person.LastName);
            }
            Console.WriteLine("\n" + "Keys:");

            foreach(string s in hash.Keys)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Access to a value through the key:");
            foreach (Object key in hash.Keys)
            {
                Person p = (Person)hash[key];
                Console.WriteLine($"Key: {key}; Value: {p.FirstName}");
            }    
        }
    }
}
