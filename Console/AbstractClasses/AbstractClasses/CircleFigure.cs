using System;

namespace AbstractClasses
{
    class CircleFigure : Figure
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("This is class Circle");
        }
    }
}
