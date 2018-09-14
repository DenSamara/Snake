using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static int Y_MAX = 30;
        static int X_MAX = 120;

        static void Main(string[] args)
        {
            Point p = new Point(10, 5, '*');

            //Point start = new Point(10, 11, '*');
            //Point end = new Point(20, 22, '*');

            //Line line = new Line(start, end);
            //line.Draw();

            Console.SetBufferSize(X_MAX, Y_MAX);

            //Верх
            HorizontalLine upFrame = new HorizontalLine(1, 1, X_MAX, '*');
            //Низ
            HorizontalLine downFrame = new HorizontalLine(1, Y_MAX-1, X_MAX, '*');
            //Лево
            VerticalLine leftFrame = new VerticalLine(1, 1, Y_MAX, '*');
            //Право
            VerticalLine rightFrame = new VerticalLine(X_MAX-1, 1, Y_MAX, '*');

            upFrame.Draw();
            downFrame.Draw();
            leftFrame.Draw();
            rightFrame.Draw();

            p.Draw();

            Console.ReadLine();
        }

    }
}
