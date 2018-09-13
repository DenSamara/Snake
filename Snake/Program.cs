using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Значение не менятся ---");
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            Console.WriteLine("--- Значение не менятся. Работает с копией переменной ---");
            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            Console.WriteLine("--- Значение не менятся, даже если назвать входной параметр так же ---");
            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Console.WriteLine("--- Передаём в функцию экземпляр, и там же меняем значения полей. Всё менятся ---");
            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.X + ", p1.y = " + p1.Y);

            Console.WriteLine("--- Сначала меняем указатель, потом значения. Меняется и там, и там ---");
            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.X = 8;
            p2.Y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.X + ", p1.y = " + p1.Y + "; p2.x = " + p2.X + ", p2.y = " + p2.Y);

            Console.WriteLine("--- Создали p1, передали в функцию, внутри пересоздали. Значение не изменилось ---");
            p1 = new Point(1, 3, '*');
            Update(p1);
            Console.WriteLine("Call Update. p1.x = " + p1.X + ", p1.y = " + p1.Y);

            Console.ReadLine();
        }

        public static void Func1(int value)
        {

        }

        /// <summary>
        /// При изменении значения переданного параметра, сам переданный параметр не меняется
        /// </summary>
        /// <param name="value"></param>
        public static void Func2(int value)
        {
            value = value + 1;
        }

        /// <summary>
        /// Называем параметр функции так же, как и переменную
        /// </summary>
        /// <param name="x"></param>
        public static void Func3(int x)
        {
            x = x + 1;
        }

        /// <summary>
        /// Меняем значение параметра на dx и dy соответственно
        /// </summary>
        /// <param name="p"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public static void Move(Point p, int dx, int dy)
        {
            p.X = p.X + dx;
            p.Y = p.Y + dy;
        }

        public static void Update(Point p)
        {
            p = new Point();
        }

    }
}
