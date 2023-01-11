using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
      public object Id { get; }
        public string Name { get; }
        public Person(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
