using System;

namespace NestedClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shed shed = new Shed();
            shed.FrontWindow.ShutWindow();
        }
    }
}
