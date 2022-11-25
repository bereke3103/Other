using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество индексов");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Введите тот элемент в котором хранятся {i};");
                myArray[i] = int.Parse(Console.ReadLine());
                
            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
