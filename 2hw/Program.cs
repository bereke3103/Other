using System;

namespace home2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите ваше первое число:");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваше второе число");
            secondValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваше третье число");
            thirdValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма двух чисел: " + firstValue + secondValue);

            Console.Write("Теперь введите ваше третье число");
            double someRes = double.Parse(Console.ReadLine());
            someRes = firstValue + secondValue;
            Console.WriteLine("Сумма трех чисел, поделенный на два: " + (someRes + thirdValue) / 2 );*/

            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            thirdValue= double.Parse(Console.ReadLine());

            double plusRes = firstValue + secondValue + thirdValue;
            double multiRes = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма трех чмсел: " + plusRes);
            Console.WriteLine("Произведение трех числе " + multiRes);


        }
    }
}
