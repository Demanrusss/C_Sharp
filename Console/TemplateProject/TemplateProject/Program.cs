using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemplateTest<int> testarray = new TemplateTest<int>();

            testarray.Add(10);
            testarray.Add(1);
            testarray.Add(3);
            testarray.Add(14);

            for (int i = 0; i <= testarray.Count() - 1; i++)
                Console.WriteLine(testarray.Get(i));

            TemplateTest<string> testarray2 = new TemplateTest<string>();

            testarray2.Add("Michail");
            testarray2.Add("Flenov");
            testarray2.Add("Dmitriy");
            testarray2.Add("Yevchenko");

            for (int i = 0; i <= testarray2.Count() - 1; i++)
                Console.WriteLine(testarray2.Get(i));
        }
    }
}
