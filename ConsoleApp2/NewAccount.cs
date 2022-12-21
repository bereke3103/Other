using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NewAccount
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.RegisterHandler(Display);
            account.RegisterHandler(ColorDisplay);
            account.Put(100);
            account.Withdraw(100);
            account.UnRegisterHandler(Display);
            //account.UnRegisterHandler(ColorDisplay);
            account.Withdraw(600);

       

            Console.ReadKey();

            
        }
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        
        static void ColorDisplay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);
        
            Console.ResetColor();
        }
    }
}
