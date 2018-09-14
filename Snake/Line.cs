using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public class Line
    {
        protected char sym = '*';
        protected List<Point> pList;

        public Line()
        {
            pList = new List<Point>();
        }

        public Line(Point start, Point end) : this()
        {
            for(int i = start.X; i <= end.X; i++ ){
                for (int j = start.Y; j <= end.Y; j++)
                {
                    pList.Add(new Point(i, j, '*'));
                }
            }
        }

        public void Draw()
        {
            foreach (Point item in pList)
            {
                item.Draw();
            }
        }
    }
}
