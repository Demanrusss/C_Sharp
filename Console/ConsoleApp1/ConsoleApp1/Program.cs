using System;


namespace ConsoleApp1
{
    class Program
    {
        enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
            Sunday};
        static void Main(string[] args)
        {
            // массив с названиями дней недели на русском
            string[] WeekdaysRussianNames = { "Понедельник", "Вторник", "Среда",
                "Четверг", "Пятница", "Суббота", "Воскресенье"};

            Weekdays day = Weekdays.Thursday;

            // вывод дня недели в разных форматах
            Console.WriteLine("Сегодня " + day);
            Console.WriteLine("Сегодня " + WeekdaysRussianNames[(int) day]);
            int dayIndex = (int) day + 1;
            Console.WriteLine("Номер дня " + dayIndex);

            // вот так можно делать проверку сравнением
            if (day == Weekdays.Friday)
                Console.WriteLine("Скоро выходной");
            Console.ReadLine();
        }
    }
}
