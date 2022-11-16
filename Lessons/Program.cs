using System;
using System.Globalization;

namespace Lessons2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Введите первое число");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            secondValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Ваше среднее число: " + (firstValue+secondValue) / 2);
    }    } 
}

