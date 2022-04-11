using System;

namespace AbstractClasses
{
    abstract class Figure
    {
        public int left { get; set; }
        public int top { get; set; }

        abstract public void Draw();
    }
}
