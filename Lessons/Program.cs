﻿using System;



namespace Lessons2
{
    /*
        полиморфизм

       абстрактный класс

       абстрактный метод

       абстрактное свойство <---почитать хорошенько
        */


    //При абстрактном класса мы не можем создавать экземпляр этого класса
    //Абстрактный класс - это некая идея, описание некого контракта, возможности некоторого поведения
    //этого объекта... т.е все использованные методы в абстрактном классе мы можем использовать
    //в наследниках нашего абстрактного класса

    //т.е создаем абстрактное оружие, в котором самая главня идея - это выстрелить.
    //А какое оружие - неважно

    //Благодаря тому, что ССЫЛКА БАЗОВОГО КЛАССА МОЖЕТ ХРАНИТЬ ЭКЗЕМПЛЯРЫ НАСЛЕДНИКОВ, то
    //В НАШЕМ БАЗОВОМ КЛАССЕ МЫ МОЖЕМ ОПИСАТЬ КАКОЙ МЕТОД МЫ БУДЕМ ИСПОЛЬЗОВАТЬ ДЛЯ ТОГО,
    //ЧТОБЫ ВЫСТРЕЛИТЬ... А УЖЕ В НАСЛЕДНИХ АБСТРАКТНОГО КЛАССЫ МЫ УЖЕ НАПИШЕМ КОНКРЕТНУЮ РЕАЛИЗАЦИЮ
    
    //СОЗДАЕМ АБСТРАКТНЫЙ КЛАСС WEAPON, который будет учить стрелять нашего Player стрелять,
    //но конкретно из какого оружия - не имеет смысла 

    abstract class Weapon
    {
        public abstract int Damage { get; }
        //1. мы можем создавать, конструкторы:
        //указывать, какие параметры туда будут входить
        //public Weapon(int a)
        //{
        //}

        //2. Также создавать какие-то методы, по типу Fire()
        public abstract void Fire(); //так как этот метод абстрактное, априори не может
                                     //там описание реализации этого метода

        //3.Абстрактный класс может содержать ни только в себе абстракные методы,
        //а также конкретные методы

        public void ShowInfo()
        {
            //Console.WriteLine(GetType().Name);
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }

    class Gun : Weapon
    {
        public override int Damage => 5;

        //Для наследования мы должны использовать override -> т.е он работает
        //как для abstract так и для virtual
        public override void Fire()
        {
            Console.WriteLine("Пыщ пыщ");
        }
    }

    class LaserGun : Weapon
    {
        public override int Damage { get { return 6 ; } }

        public override void Fire()
        {
            Console.WriteLine("Пииииу");
        }
    }

    class Bow : Weapon
    {
        public override int Damage => 8;

        public override void Fire()
        {
            Console.WriteLine("Чпуньк");
        }
    }

    class Player
    {
        //В этот метод Fire мы передадим объект типа Weapon
        public void Fire(Weapon weapon)
        {
            //теперь вызываем Fire
            weapon.Fire();
        }

        public void CheckInfo (Weapon weapon)
        {
            weapon.ShowInfo();
        }


    }

    class Programm
    {
       

        static void Main(string[] args)
        {
            //создаем экземпляр класса
            Player player = new Player();
            //Gun gun = new Gun();
            //player.Fire(gun);

            //отредактируем код
            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine(); //это просто пробел

                //11:23
            }
        }

    }
}

