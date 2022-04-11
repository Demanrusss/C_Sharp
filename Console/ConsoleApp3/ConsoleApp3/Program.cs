using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Matrix is in you";

            // Change color to Blue
            Console.ForegroundColor = ConsoleColor.Blue;
            // Next string will be in blue
            Console.WriteLine("Hello, world!");

            // Change color to red
            Console.ForegroundColor = ConsoleColor.Red;
            // Next string will be in red
            Console.WriteLine("Where are you now?");

            Console.BackgroundColor = ConsoleColor.White;

            if (Console.CapsLock)
                Console.WriteLine("Push off the CapsLock button.");

            if (Console.NumberLock)
                Console.WriteLine("Push off the NumLock button.");

            // Working with Console buffer
            Console.WriteLine(Console.BufferHeight);
            Console.WriteLine(Console.BufferWidth);

            ConsoleColor[] colors = {ConsoleColor.Blue, ConsoleColor.Red,
                                     ConsoleColor.White, ConsoleColor.Yellow};
            foreach (ConsoleColor color in colors)
            {
                Console.CursorLeft = (Console.BufferWidth - 
                                      color.ToString().Length) / 2;
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {

            }
        }
    }
}
