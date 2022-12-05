using System;


namespace Lesson {
    /*
     Свойства (Properties)
     Автоматические свойства
     */

    class Point
    {
        //В нашем контексте присутсвует поле Х
        private int x;

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(1); //устанавливаем сет

            int x = point.GetX(); //получаем доступ к нему
        }
    }
}
