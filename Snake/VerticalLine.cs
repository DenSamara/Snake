using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine : Line
    {
        public VerticalLine(int x, int y, int length, char sym)
        {
            this.sym = sym;
            for (int i = 0; i < length - 1; i++)
            {
                pList.Add(new Point(x, y+i, sym));
            }
        }
    }
}
