using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationWith
{
    public class CreateUserVerb
    {
        void CreateUser(string name, int age)
        {
            User user = new User(name, age);
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(user, context, results, true))
            {
                Console.WriteLine("Не удалось создать объект");
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine($"Объект создани {user.Name}");
            }
        }
    }
}
