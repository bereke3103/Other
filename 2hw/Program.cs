using System;

namespace home2
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 0; i < 15; i++)
            {
                if (i == 11)
                {
                    continue;
                    
                }
                Console.WriteLine(i);
            }

        }
    }
}
