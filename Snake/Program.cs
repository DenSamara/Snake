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

            int centerX = (int)(X_MAX / 2);
            int centerY = (int)(Y_MAX / 2);
            Point start = new Point(centerX, centerY, '+');

            Random rand = new Random();

            Snake snake = new Snake(start, 3, (Direction)rand.Next(3));
            snake.Draw();

            FoodCreator creator = new FoodCreator(X_MAX, Y_MAX, '$');
            Point food = creator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.isHit(snake) || snake.isHitTale()) break;

                if (snake.IsSnakeEat(food))
                {
                    food = creator.CreateFood();
                    food.Draw();
                }

                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey());
                }

                snake.Move();
                snake.Draw();
                Thread.Sleep(100);
            }
		}

    }
}
