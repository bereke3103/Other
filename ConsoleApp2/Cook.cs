using ConsoleApp2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }

    }
}
