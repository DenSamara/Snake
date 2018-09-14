using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Snake
{
    public class Point
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

        public Point()
            : this(0, 0, '*')
        {

        }

        public Point(Point point)
            : this(point.x, point.y, point.sym)
        {

        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public char Sym
        {
            set { sym = value; }
            get { return sym; }
        }

        public void Draw()
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
            }
            catch (Exception)
            {
                string msg = String.Format("x = {0}, y = {1}", x, y);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Двигаем точку в нужном направлении.
        /// TODO Проверка выхода за границы?
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="direction"></param>
        public void Move(int delta, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    x -= delta;
                    break;
                case Direction.Right:
                    x += delta;
                    break;
                case Direction.Up:
                    y -= delta;
                    break;
                case Direction.Down:
                    y += delta;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, char = {2}", x, y, sym);
        }
    }
}
