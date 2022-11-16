using System;
using System.Globalization;

namespace Lessons2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int a = 1;
            int b = 9;
            Console.WriteLine(a + b * 9);*/


            //КОНВЕРТИРУЕМ ВАШ ТЕНГЕ В РУБЛЬ
            /*            string str;
                        int a;
                        Console.WriteLine("Напшите тенге, и я вам покажу сколько это будет в рублях");
                        str = Console.ReadLine();
                        a = int.Parse(str);

                        Console.WriteLine(a * 5);*/


            //КОНВЕРТИРУЕМ ВАШ ДОЛЛАР В РУБЛЬ

            /*string str;
            double a;
            Console.WriteLine("Напишите ваш ДОЛЛАР, и мы конвертируем это в РУБЛЬ");

            str = Console.ReadLine();
            a = double.Parse(str);
            Console.WriteLine(a * 60.79);*/

            //КОНВЕРТИРУЕМ ВАШ ДОЛЛАР В ТЕНГЕ
            Console.WriteLine("Напишите ваш доллар для конвертации в тенге");

            string str = Console.ReadLine();
            int a = int.Parse(str);
            Console.WriteLine("Ваш тенге: " + a * 460);





    }    } 
}

