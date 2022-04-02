using System;

namespace EasyCSharp
{
    class Program
    {
        enum Weekdays { Monday, Tuesday, Wednesday, 
                        Thursday, Friday, Saturday, Sunday };
        static void Main(string[] args)
        {
            string[] WeekdaysRussianNames = { "Понедельник", "Вторник", 
                "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

            Weekdays day = Weekdays.Thursday;

            // Print out days of the week in different formats

            Console.WriteLine("Сегодня " + day);
            Console.WriteLine("Сегодня " + WeekdaysRussianNames[(int)day]);
            int dayIndex = (int)day + 1;
            Console.WriteLine("Номер дня " + dayIndex);

            if (day == Weekdays.Friday)
                Console.WriteLine("Скоро выходной");
            Console.ReadLine();
        }
    }

}