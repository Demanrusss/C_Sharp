using System;
using System.Text;

namespace ConsoleApp2
{
    // объявление класса программы
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект
            Shed myFirstShed = new Shed();

            // задаем значение свойств
            myFirstShed.Width = 20;
            myFirstShed.Height = 10;
            myFirstShed.Lengthwise = myFirstShed.Width;

            int size = myFirstShed.GetSize();
                        
            // вывод на экран значений
            Console.WriteLine("Height " + myFirstShed.Height);
            Console.WriteLine("Width " + myFirstShed.Width);
            Console.WriteLine("Lengthwise " + myFirstShed.Lengthwise);
            Console.WriteLine("Volume " + size);
            Console.WriteLine("Volume " + myFirstShed.GetSize());

            myFirstShed.ExpandSize(2, 4, 6);

            // вывод на экран значений после расширения
            Console.WriteLine("Height " + myFirstShed.Height);
            Console.WriteLine("Width " + myFirstShed.Width);
            Console.WriteLine("Lengthwise " + myFirstShed.Lengthwise);
            Console.WriteLine("Volume " + size);
            Console.WriteLine("Volume " + myFirstShed.GetSize());

            int vx = 2, vy = 4, vz = 6;

            myFirstShed.ExpandAndGetSize(ref vx, ref vy , ref vz);

            // вывод на экран значений после второго расширения
            Console.WriteLine("Height " + myFirstShed.Height);
            Console.WriteLine("Width " + myFirstShed.Width);
            Console.WriteLine("Lengthwise " + myFirstShed.Lengthwise);
            Console.WriteLine("Volume " + size);
            Console.WriteLine("Volume " + myFirstShed.GetSize());

            myFirstShed.ExpandSize(2, 4);

            // вывод на экран значений после третьего расширения
            Console.WriteLine("Height " + myFirstShed.Height);
            Console.WriteLine("Width " + myFirstShed.Width);
            Console.WriteLine("Lengthwise " + myFirstShed.Lengthwise);
            Console.WriteLine("Volume " + size);
            Console.WriteLine("Volume " + myFirstShed.GetSize());

            // использование метода2
            myFirstShed.ExpandAndGetSize2(10, out vx, out vy, out vz);
            Console.WriteLine("Размеры 2: " + vx + " " + vy + " " + vz);

            // работа со статичностью гл. 3.3.5
            Shed shed1 = new Shed();
            Console.WriteLine(shed1.GetObjectNumber());
            Shed shed2 = new Shed();
            Console.WriteLine(shed2.GetObjectNumber());

            Console.ReadLine();
        }
    }
}