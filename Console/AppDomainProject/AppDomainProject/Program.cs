using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So now we are about to launch another build");

            AppDomain appD = AppDomain.CreateDomain("My Domain");
            appD.ExecuteAssembly(@"D:\Coding\C_Sharp\Console\DomainTest\DomainTest\bin\Debug\DomainTest.exe");

            Console.ReadLine();
        }
    }
}
