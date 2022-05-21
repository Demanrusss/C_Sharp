using System.Collections;
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
    }
}