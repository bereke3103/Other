using System;



namespace Lessons2
{
    /* 
     * 
     ПОЛИМОРФИЗМ:
    - Virtual

    - Override


     */

    //это метод - базового класса добавляем virtual
    class Car
    {

        //0. Virtual -> те методы и свойства, которые мы хотим  сделать доступными
        //для переопределния, в базовом классе помечается этим модификатором
        //1. Если стоит Private void, то он доступен для класса, в котором он написан
        //в данном случае в классе Car
        //2. Если стоит модификатор private -> то мы НЕ МОЖЕМ использовать модификаторы
        //полиморфизма так как это бессмысленно 
        //3. Для этого используем такой модификатор, как protected и после него
        //прописываем модификатор полиморфизма virtual -->> Будет все ок
        //4. Но это будет доступно только для наследника, а ни для экземпляра класса
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен");
        }
        //метод, который ничего не возращает так как у него стоит
        //тип возвращаемого значения void
        public virtual void Drive() 
        {
            StartEngine();
            Console.WriteLine("Я машина, я еду");
        }
    }

    //В класс наследника добавляем override
    class SportCar : Car
    {
        //для наследника метод startEngine мы также можем переопределить, написав override
        //0. Override -> чтобы переопределить метод в классе наследнике, этот метод
        //переопределяется этим модификатором

        protected override void StartEngine()
        {
            //base.StartEngine();

            Console.WriteLine("РОН ДОН ДОН");
        }

        public override void Drive()
        {
            //1. Здесь не будет работать метод Car.StartEngine так как он является
            //приватным....
            //StartEngine();
            //base.Drive -> вызывет метод базового класса т.е Car
            //base.Drive();
            StartEngine();
            Console.WriteLine("Я еду очень быстро");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
           // Car car = new Car(); //Создаем объект класс Car
            Person person = new Person(); //Создаем объект класс Person
            person.Drive(new SportCar()); //в метод person нашему объекту person передаем объект car
        }
    }
}

//Работает потому что, Ссылка у которого тип базового класса
//может хранить объекты класса наследников