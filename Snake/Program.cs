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

            DrawFrame();

            VerticalLine vl = new VerticalLine( 0, 10, 5, '%' );
			Draw( vl );

			Point p = new Point( 4, 5, '*' );
			Figure fSnake = new Snake( p, 4, Direction.Right );
			Draw( fSnake );
			Snake snake = (Snake) fSnake;

			HorizontalLine hl = new HorizontalLine( 0, 5, 6, '&' );

			List<Figure> figures = new List<Figure>();
			figures.Add( fSnake );
			figures.Add( vl );
			figures.Add( hl );

			foreach(var f in figures)
			{
				f.Draw();
			}

            Console.ReadLine();
		}

		static void Draw( Figure figure )
		{
			figure.Draw();
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
