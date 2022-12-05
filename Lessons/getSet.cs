using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    class Point
    {
        private int x;

        public void SetX(int x)
        {
            if(x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }

            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        //=================================================================

        //сниппет propfull - для установления get и set


        //myVar
        private int y;


        //MyProperty
        public int Y
        {
            //y - myVar
            get { return y;}
            //y - myVar

            //ключевое слово Value -> это тоже самое, что входящие параметры
            //в сеттере
            // и здесь, то что ннаписаное y -> private int, он себе
            // присваевает значение
            set { y = value; }
        }



        //=================================================================

        //АВТОМАТИЧЕСКИЕ СВОЙСТВА

        public int Z { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            
            //для Х
            //point.SetX(10);
            //int x = point.GetX();

            //для Y
            //Когда мы что-то присваеваем в свойство Y -> у нас вызывется
            //часть кода set, и то значение, которое мы пытаемся присвоить, будет
            //в значение т.е в Value 
            point.Y = 10;

            //здесь он обращается к get
            int y = point.Y;

        }
    }
}
