using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int temp = a % 2;

            bool result = temp == 0;

            if (result) 
            {
                Console.WriteLine("ЧИЛО ЧЕТНОЕ");
            } else
            {
                Console.WriteLine("ЧИЛО НЕ ЧЕТНОЕ");
            }
        }
    }
}
