using System;

namespace PersonClass
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public new bool Equals(Object obj)
        {
            Person person = (Person)obj;
            
            return (FirstName == person.FirstName) &&
                   (LastName == person.LastName);
        }

        public string ComparePersons(Person person)
        {
            bool equalParams = Equals(person);
            bool fullEqual = base.Equals(person);

            if (fullEqual)
                return "Objects are absolutely identical";
            if (equalParams)
                return "Properties of objects are identical";

            return "Objects are different";
        }
    }
}
