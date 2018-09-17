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

            for (int i = 1; i < length; i++ )
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

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
