using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"D:\Coding\C_Sharp\Console\LinqXml\person.xml");

            // Filter people who under 30
            Console.WriteLine("Person who is under 30");
            foreach (var item in root.Elements("person").Where(m =>
                Int32.Parse(m.Attribute("Age").Value) < 30))
            {
                Console.WriteLine(item.Attribute("FirstName").Value + " " +
                    item.Attribute("Age"));
            }

            // Filter by city in address
            Console.WriteLine("Person who lives in Moskow");
            foreach (var item in root.Elements("person").Where(m =>
                m.Elements("address").Elements("city").FirstOrDefault().Value == "Moskow"))
            {
                Console.WriteLine(item.Attribute("FirstName").Value + " " + 
                    item.Attribute("LastName").Value);
            }
        }
    }
}
