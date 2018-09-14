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
            //Point p = new Point();

            //Point start = new Point(10, 11, '*');
            //Point end = new Point(20, 22, '*');

            //Line line = new Line(start, end);
            //line.Draw();

            HorizontalLine hLine = new HorizontalLine(10, 10, 10, '-');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(10, 10, 10, '|');
            vLine.Draw();

            Console.ReadLine();
        }

    }
}
