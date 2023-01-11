using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(123, "Bereke");
            Person person1 = new Person("123", "Bereke");

            int berekeInt = (int)person.Id;
            string berekeString = (string)person1.Id;

            Console.WriteLine(berekeInt);
            Console.WriteLine(berekeString);
            Console.ReadLine();
        }
    }
}
