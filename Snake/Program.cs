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
            Point p = new Point(3, 5, '*');

            p.Draw();

            Point p1 = new Point(10, 7, '=');
            p1.Draw();

            Console.ReadLine();
        }

    }
}
