using Newtonsoft.Json;
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
            
             Person<int, string> person = new Person<int, string>(123, "Bereke");

            var result = JsonConvert.SerializeObject(person);

            Console.WriteLine(person.id);
            Console.WriteLine(person.name);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
