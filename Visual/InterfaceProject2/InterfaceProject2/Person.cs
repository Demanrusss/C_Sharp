using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject2
{
    internal class Person : IPurse
    {
        // Announcing variables
        private string name;
        private string surname;
        private int sum;
        
        // Announcing Properties
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

        // Announcing constructor
        public Person(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
        }

        // Announcing methods
        public void AddMoney(int a)
        {
            Sum += sum;
        }
        public int DecMoney(int a)
        {
            Sum -= sum;
            return Sum;
        }
    }
}
