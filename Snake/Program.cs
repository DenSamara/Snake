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
            Point p = new Point();
            Point p1 = new Point(10, 11, '*');
            Point p2 = new Point(20, 22, '=');
            Point p3 = new Point(30, 33, '^');


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            foreach (int item in numList)
            {
                Console.WriteLine("item = "+item);
            }

            List<Point> pointList = new List<Point>();
            pointList.Add(p);
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);

            foreach (Point item in pointList)
            {
                Console.WriteLine("item = " + item);
                item.Draw();
            }

            Console.ReadLine();
        }

    }
}
