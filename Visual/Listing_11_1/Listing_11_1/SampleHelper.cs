using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_11_1
{
    internal class SampleHelper
    {
        static public List<Person> CreatePersons()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 20; i++)
                persons.Add(new Person ($"Ivan {i}", $"Ivanov {i}", 15 + i));
            
            return persons;
        }
       
    }
}
