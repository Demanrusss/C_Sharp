using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new
            {
                Name = "Dmitriy",
                Surname = "Yevchenko",
                Age = 30,
                Number = 12345678900
            };

            Console.WriteLine("Name: {0}\nSurname: {1}\nAge: {2}\nNumber: {3}",
                p.Name, p.Surname, p.Age, p.Number);

            Console.WriteLine("\nUsing string.Format");
            string result = string.Format("Name: {0}\nSurname: {1}\nAge: {2}\nNumber: {3}",
                p.Name, p.Surname, p.Age, p.Number);
            Console.WriteLine(result);

            Console.WriteLine("\nUsing Interpolation");
            result = string.Format($"Name: {p.Name}\nSurname: {p.Surname}\nAge: {p.Age}\n" +
                $"Number: {p.Number.ToString("+# (###) ###-##-##")}");
            Console.WriteLine(result);
        }
    }
}
