using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeArray
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        // Constructor
        public Person()
        {
            Name = "Name";
            Surname = "Surname";
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
