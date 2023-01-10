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

            Person person = new Person("Bereke");
            person.CheckName();

            //++++++++++++++++++++++++++++++++\

            Employee employee = new Employee("Tom", "Microsoft");
            employee.CheckName();


            Console.ReadLine();

        }

    }
}
