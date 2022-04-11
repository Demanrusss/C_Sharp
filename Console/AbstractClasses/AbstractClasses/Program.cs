using System;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure rect;
            rect = new RectangleFigure();
            rect.Draw();

            rect = new CircleFigure();
            rect.Draw();

            Figure shape = new CircleFigure();

            if (shape is CircleFigure)
                Console.WriteLine("shape is really object of class CircleFigure.");

            CircleFigure circle = (CircleFigure)shape;
            // Or CircleFigure cicle = shape as CircleFigure

            if (circle is CircleFigure)
                Console.WriteLine("circle is really object of class CircleFigure");
        }
    }
}
