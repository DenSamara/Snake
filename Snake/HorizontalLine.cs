using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizontalLine : Line
    {
        public HorizontalLine(int x, int y, int length, char sym)
        {
            this.sym = sym;
            for (int i = 0; i < length - 2; i++)
            {
                pList.Add(new Point(x+i, y, sym));
            }
        }
    }
}
