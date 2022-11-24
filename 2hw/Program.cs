using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "hello")
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
