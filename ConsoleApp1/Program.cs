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

            Person person = new Person() { Name = "Bereke" };

            person.CheckName();

            //============================================================

            //так как уже был унаследован от Person мы можем переиспользовать его

            Employee employee = new Employee() { Name = "Employee" };

            employee.CheckName();

            Console.ReadLine();

        }

    }
}
