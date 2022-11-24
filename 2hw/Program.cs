using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {

            //нечетное число
            uint evenNumber = 0;
            int evenSum = 0;

            //четное число
            uint oddNumber = 0;
            int oddSum = 0;

            int currentValue = int.Parse(Console.ReadLine());
            int limitValue = int.Parse(Console.ReadLine());

            while (currentValue <= limitValue)
            {
                if (currentValue % 2==0)
                {
                    evenSum = evenSum + currentValue;
                    evenNumber++;
                } else
                {
                    oddSum = oddSum + currentValue;
                    oddNumber++;
                }
                currentValue++;
            }

            Console.WriteLine(evenNumber);
            Console.WriteLine(oddNumber);
            Console.WriteLine(oddSum);
            Console.WriteLine(evenSum);

        }
    }
}
