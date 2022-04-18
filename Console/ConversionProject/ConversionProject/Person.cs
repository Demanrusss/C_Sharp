using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionProject
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string PointName { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + X.ToString() + ":" + Y.ToString()
                + " " + PointName;
        }
    }
}
