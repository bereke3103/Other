using ConsoleApp2.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook bereke = new Cook("Bereke");
            bereke.MakeDinner(new SaladMeal());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
