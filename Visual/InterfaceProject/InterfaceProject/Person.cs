using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Person: IPurse
    {
        // Methods of class Person
        public string name;
        public string surname;
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

        public Person(string firstname, string lastsurname)
        {
            FirstName = name;
            LastName = surname;
        }

        // Realization of interface
        int sum = 0;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public void AddMoney(int sum)
        {
            Sum += sum;
        }
        public int DecMoney(int sum)
        {
            Sum -= sum;
            return sum;
        }
    }
}
