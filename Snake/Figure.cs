﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public class Figure
    {
        protected char sym = '*';
        protected List<Point> pList;

        public Figure()
        {
            pList = new List<Point>();
        }

        //public Figure(Point start, Point end) : this()
        //{
        //    for(int i = start.X; i <= end.X; i++ ){
        //        for (int j = start.Y; j <= end.Y; j++)
        //        {
        //            pList.Add(new Point(i, j, '*'));
        //        }
        //    }
        //}

        public void Draw()
        {
            foreach (Point item in pList)
            {
                item.Draw();
            }
        }

        public bool isHit(Point point)
        {
            foreach (Point item in pList)
            {
                if (item.isHit(point)) return true;
            }
            return false;
        }

        public bool isHit(Figure figure)
        {
            foreach (Point item in figure.pList)
            {
                if (isHit(item)) return true;
            }
            return false;
        }
    }
}
