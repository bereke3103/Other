using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class MealBase
    {
        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
        public void Make()
        {
            Prepare();
            Cook();
            FinalSteps();
        }
    }
}
