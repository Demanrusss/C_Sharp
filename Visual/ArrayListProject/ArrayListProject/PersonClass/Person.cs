using System.Collections;
using System;
using ArrayListProject;

namespace PersonClass
{
    internal class Person
    {
        // Devoting variables
        private string name;
        private string surname;

        // Devoiting an array
        ArrayList Children = new ArrayList();

        // Devoting properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        // Devoting constructor
        public Person(string firstName, string lastName)
        {
            Name = firstName;
            Surname = lastName;
        }

        // Devoting Methods
        public void AddChild(string firstName, string lastName)
        {
            Children.Add(new Person(firstName, lastName));
        }
        public void DeleteChild(int index)
        {
            Children.RemoveAt(index);
        }
        public Person GetChild(int index)
        {
            return (Person)Children[index];
        }
        public int GetChildrenNumber()
        {
            return Children.Count;
        }
        public Person this[int index]
        {
            get { return (Person)Children[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(this);
        }

        public void SortChildren()
        {
            Children.Sort(new SortTest());
        }

        public int IComparerable(object obj)
        {
            Person person = obj as Person;
            int result = this.Surname.CompareTo(person.Surname);

            if (result == 0)
            {
                return this.Name.CompareTo(person.Name);
            }

            return result;
        }

        int IComparer(Object person1, Object person2)
        {
            string personName1 = ((Person)person1).ToString();
            string personName2 = ((Person)person2).ToString();

            return personName1.CompareTo(personName2);
        }

        public new string ToString()
        {
            return Name + " " + Surname;
        }
    }
}