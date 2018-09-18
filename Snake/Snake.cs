using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public class Snake : Figure
    {
        private char bodySymb = '*';
        private Direction direction;

        public Snake(Point headPosition, int length, Direction moveDirection)
        {
            this.direction = moveDirection;

            //Добавляем голову. Все остальные будут выглядеть по-другому
            pList.Add(headPosition);

            for (int i = 1; i < length; i++)
            {
                Point newPoint = new Point(headPosition);
                newPoint.Move(i, moveDirection);
                newPoint.Sym = bodySymb;

                pList.Add(newPoint);
            }

            //Draw();
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Direction SetDirection
        {
            set { direction = value; }
            get { return direction; }
        }

        public Point GetNextPoint()
        {
            Point tale = pList.Last();
            Point nextPoint = new Point(tale);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    direction = Direction.Right;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Down;
                    break;
                default:
                    break;
            }
        }

        public bool IsSnakeEat(Point food)
        {
            Point tale = GetNextPoint();

            if (tale.isHit(food))
            {
                food.Sym = tale.Sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
