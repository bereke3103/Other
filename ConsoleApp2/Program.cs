using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //определяем делегат
    delegate void AccountStateHandler(string message);
    class Account
    {
        //хранит средства на счете
        int _sum;
        //определим в этом классе переменную делегата
        AccountStateHandler _del; //равна значению null
        //чтоб этот делегат установить, определяем метод
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del;
        }
        
        public void UnRegisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }
        public Account(int sum)
        {
            //с помощью конструктора передаем
            //этой переменной некоторые значения
            _sum = sum;
        }

        public void Put(int sum)
        {
            _sum += sum;
                if(_del != null)
                    _del($"На счёт пришло {sum}");

        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                if(_del != null)
                    _del($"Со счёта ушло {sum}");
            } else
            {
                if (_del != null)
                    _del("Недостаточно средств на балансе");
            }
        }
    }

    //========================================================================
    //
}
