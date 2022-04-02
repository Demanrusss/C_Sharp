using System;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Михаил", "Фленов");
            Console.WriteLine(p.ToString());

            Object o = p;
            Console.WriteLine(o.ToString());

            // второй пример
            Person p1 = new Person("Michail", "Flenov");
            Person p2 = new Person("Michail", "Flenov");
            Person p3 = p1;

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

            // третий пример на основе использования new
            string ComparePersons(Person person1, Person person2)
            {
                bool equalParams = person1.Equals(person2);
                Object personobj = person1;
                bool fullEqual = personobj.Equals(person2);

                if (fullEqual)
                    return "Objects are absolutely identical!";
                if (equalParams)
                    return "Properties of objects are identical";

                return "Objects are different";
            }

            Console.WriteLine(ComparePersons(p1, p2));

            Console.ReadLine();
        }
    }
}
