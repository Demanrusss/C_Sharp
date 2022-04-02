using System;

namespace NestedClass
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
