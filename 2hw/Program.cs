using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4, 5, };

            for (int i = myArr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArr[i]); 
            }

        }
    }
}
