using System;



namespace Lessons
{
    class Program
    {
        /* static void Main(string[] args)
         {
             int a, b;
             a = 5;
             b = 10;
             Console.WriteLine(a);
             Console.WriteLine(b);

             string aLotOfStrings = "dsadasda";
             Console.WriteLine(aLotOfStrings);
             char oneSymbol = 'v';
             Console.WriteLine(oneSymbol);

             string data;
             data = Console.ReadLine();
             Console.WriteLine("Привет "+data);
         }
        */
        /*static void Main(string[] args)
         {
             string str;

             int a, b, c;

             Console.WriteLine("Введите ваше первое число");
             str = Console.ReadLine();
             a = Convert.ToInt32(str);

             Console.WriteLine("Введите ваше второе число");
             str = Console.ReadLine() ;

             b = Convert.ToInt32(str) ;

             Console.WriteLine("Введите ваше третье число");
             str = Console.ReadLine() ;
             c = Convert.ToInt32(str) ;

             int result = a + b + c ;

             Console.WriteLine("Ваш результат: " +result);



         }*/

        static void Main(string[] args)
        {
            /* string str = "511";

             try
             {
                 int a = int.Parse(str);
                 Console.WriteLine("Конвертация прошла успешна");
             }
             catch (Exception)
             {

                 Console.WriteLine("Введите правильное число");
             }*/

            string str = "555dsa";
            int a;
            bool result = int.TryParse(str, out a);
            
            if(result )
            {
                Console.WriteLine("Конвертация прошла успешна" + a);
            } else
            {
                Console.WriteLine("Напигите нормално");
            }

        }
    }
}

