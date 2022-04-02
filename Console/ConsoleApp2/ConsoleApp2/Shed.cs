using System;
using System.Text;

namespace ConsoleApp2
{
    class Shed
    {
        int width;
        int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }

        // конструкторы для сарая гл. 3.3.4
        public Shed(int w, int l, int height)
        {
            width = w;
            Lengthwise = l;
            this.height = height;
        }

        public Shed()
        {
            width = 1;
            Lengthwise = 1;
            this.height = 1;
            ObjectNumber++;
        }

        public int GetSize()
        {
            int size = width * height * Lengthwise;
            return size;
        }

        public void ExpandSize(int x, int y, int h)
        {
            Width += x;
            Lengthwise += y;
            Height += h;
        }

        public void ExpandSize(int x, int y)
        {
            Width += x;
            Lengthwise += y;
        }

        public void ExpandAndGetSize(ref int x, ref int y, ref int h)
        {
            ExpandSize(x, y, h);
            x = Width;
            y = Lengthwise;
            h = Height;
        }

        public void ExpandAndGetSize2(int inc, out int x, out int y, out int h)
        {
            ExpandSize(inc, inc, inc);
            x = Width;
            y = Lengthwise;
            h = Height;
        }

        // Работа со статичностью гл. 3.3.5
        static int ObjectNumber = 0;

        public int GetObjectNumber()
        {
            return ObjectNumber;
        }

    }
}
