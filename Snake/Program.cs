using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

            Wall walls = new Wall(X_MAX, Y_MAX);
            walls.Draw();

            Console.ReadLine();
		}

    }
}
