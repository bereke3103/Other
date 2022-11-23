using System;

namespace home2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());

            if (a >= 5)
            {
                Console.WriteLine("Проверка прошла успешна");
            } else
            {
                Console.WriteLine("Ошибка");
            }


        }
    }
}
