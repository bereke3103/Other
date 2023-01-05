using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationWithout
{
    public class CreateUserVerb
    {
        void CreateUser(string name, int age)
        {
            User user = new User(name, age);

            if (user.Name.Length >= 3 && user.Name.Length <= 50)
            {
                Console.WriteLine($"Name: {user.Name}");
            }
            else
            {
                Console.WriteLine("Incorrect name");
            }

            if (age >= 1 && age <= 100) 
            {
                Console.WriteLine($"Age: {user.Age}");
            }
            else
            {
                Console.WriteLine("Incorrect age");
            }

        }
    }
}
