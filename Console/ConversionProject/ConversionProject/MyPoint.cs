using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionProject
{
    internal class MyPoint
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string PointName { get; set; }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static explicit operator MyPoint(Person p)
        {
            MyPoint point = new MyPoint(p.X, p.Y);
            point.PointName = p.PointName;
            return point;
        }

        public override string ToString()
        {
            return X.ToString() + ":" + Y.ToString() + " " + PointName;
        }
    }
}
