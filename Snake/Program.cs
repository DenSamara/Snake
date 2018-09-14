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
            Console.SetBufferSize(X_MAX, Y_MAX);
            Console.CursorVisible = false;

            DrawFrame();

            int centerX = (int)(X_MAX/2);
            int centerY = (int)(Y_MAX/2);
            Point start = new Point(centerX, centerY, '+');

            Random rand = new Random();

            Snake snake = new Snake(start, 3, (Direction)rand.Next(3));

            Console.ReadLine();
        }

        private static void DrawFrame()
        {
            //Верх
            HorizontalLine upFrame = new HorizontalLine(1, 1, X_MAX, '*');
            //Низ
            HorizontalLine downFrame = new HorizontalLine(1, Y_MAX - 1, X_MAX, '*');
            //Лево
            VerticalLine leftFrame = new VerticalLine(1, 1, Y_MAX, '*');
            //Право
            VerticalLine rightFrame = new VerticalLine(X_MAX - 1, 1, Y_MAX, '*');

            upFrame.Draw();
            downFrame.Draw();
            leftFrame.Draw();
            rightFrame.Draw();
        }

    }
}
