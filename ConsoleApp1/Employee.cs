using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee : Person
    {

        public string Company { get; set; }

        public Employee(string name, string compnay) : base(name)
        {
            Company = compnay;
        }
        
    }
}
