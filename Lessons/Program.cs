using System;



namespace Lessons2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        ConsoleKey key = Console.ReadKey().Key;

        //        int keyCode = (int)key;

        //        Console.WriteLine($"\tEnum {key}\tKey code {keyCode}");

        //        if (key == ConsoleKey.Enter)
        //        {
        //            Console.WriteLine("Вы нажали enter!");
        //        }
        //    }
        //}


        enum DayOfWeek
        {
            Monday = 5,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            DayOfWeek firstDay = DayOfWeek.Monday;
            DayOfWeek secondDay = DayOfWeek.Tuesday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            Console.WriteLine((int)secondDay);
        }

    }
}

