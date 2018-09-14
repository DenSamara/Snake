using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public class Snake : Figure
    {
        private char bodySymb = '*';

        public Snake(Point headPosition, int length, Direction moveDirection)
        {
            //Добавляем голову. Все остальные будут выглядеть по-другому
            pList.Add(headPosition);

            for (int i = 1; i < length; i++ )
            {
                Point newPoint = new Point(headPosition);
                newPoint.Move(i, moveDirection);
                newPoint.Sym = bodySymb;

                pList.Add(newPoint);
            }

            Draw();
        }
    }
}
