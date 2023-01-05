using ConsoleApp2.Food;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };

            Cook bob = new Cook("Bereke");
            bob.MeakDinner(menu);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
