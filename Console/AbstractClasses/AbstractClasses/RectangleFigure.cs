using System;

namespace AbstractClasses
{
    class RectangleFigure : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("This is class Rectangle");
        }
    }
}
