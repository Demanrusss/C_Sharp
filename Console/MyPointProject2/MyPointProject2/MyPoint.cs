using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointProject2
{
    public class MyPoint
    {
        int x;
        int X
        {
            get { return x; }
            set { x = value; }
        }

        int y;
        int Y
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

        public static bool operator < (MyPoint p1, MyPoint p2)
        {
            return (p1.X + p1.Y < p2.X + p2.Y);
        }

        public static bool operator > (MyPoint p1, MyPoint p2)
        {
            return (p1.X + p1.Y > p2.X + p2.Y);
        }
    }
}
