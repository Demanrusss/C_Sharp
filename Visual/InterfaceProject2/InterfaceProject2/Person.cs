using System;
using InterfaceProject2.Interfaces;

namespace InterfaceProject2
{
    class Person : IPurse, ITriplePurse, IClone
    {
        // Declaring variables
        private string name;
        private string surname;
        private int sum;

        // Declaring Properties
        public string FirstName
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        // Declaring constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Declaring methods
        public void AddMoney(int amount)
        {
            Sum += amount * 2;
        }
        void IPurse.AddMoney(int amount)
        {
            Sum += amount;
        }
        public void DecMoney(int amount)
        {
            Sum -= amount * 2;
        }
        void IPurse.DecMoney(int amount)
        {
            Sum -= amount;
        }
        void ITriplePurse.AddMoney(int amount)
        {
            Sum += amount * 3;
        }
        void ITriplePurse.DecMoney(int amount)
        {
            Sum -= amount * 3;
        }
        object IClone.Clone()
        {
            Person p = new Person(this.FirstName, this.LastName);
            return p;
        }
    }
}
