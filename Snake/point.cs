using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point(int x, int y, char ch)
        {
            this.x = x;
            this.y = y;
            this.sym = ch;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
