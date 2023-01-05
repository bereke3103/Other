using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MeakDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu)
            {
                meal.Make();
            }
        }
    }
}
