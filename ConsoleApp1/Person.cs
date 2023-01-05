using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamplePhone
{
    struct Person
    {
        public string name;
        public int age;

        public Person() : this("Tom") { }
        public Person(string name) : this(name, 23) { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}
