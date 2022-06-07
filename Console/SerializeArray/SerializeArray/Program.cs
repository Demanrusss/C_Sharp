using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SerializeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saving data
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Ivan", "Ivanov"));
            persons.Add(new Person("Sergei", "Petrov"));

            // Create a file
            FileStream fsout = new FileStream("people.dat", FileMode.Create, 
                FileAccess.Write);

            // serialization of data
            XmlSerializer serializerout = new XmlSerializer(typeof(List<Person>), 
                new Type[] {typeof(Person)});
            serializerout.Serialize(fsout, persons);
            fsout.Close();

            // Load data
            List<Person> persons1 = new List<Person>();
            FileStream fsin = new FileStream("peoples.dat", FileMode.Open, 
                FileAccess.Read);

            // Deserialization data
            XmlSerializer serializerin = new XmlSerializer(typeof(List<Person>),
                new Type[] { typeof(Person) });
            persons1 = (List<Person>)serializerin.Deserialize(fsin);
            fsin.Close();

            // Check up
            foreach (Person person in persons1)
                Console.WriteLine(person.Name);
            Console.ReadLine();
        }
    }
}
