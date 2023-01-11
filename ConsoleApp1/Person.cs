using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person<T, K>
    {
      public T id { get; }
      public K name { get; }

        public Person(T id, K name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
