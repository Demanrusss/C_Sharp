using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointProject
{
    public class MyPoint
    {
        int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return x.ToString() + ":" + y.ToString();
        }

        public static MyPoint operator + (MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static MyPoint operator - (MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X - p2.X, p1.Y - p2.Y);
        }
    }
}
