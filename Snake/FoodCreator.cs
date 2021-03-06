﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int x_max = 80;
        int y_max = 25;
        char symbol = '$';
        
        Random random;

        public FoodCreator(int x, int y, char symbol)
        {
            this.x_max = x;
            this.y_max = y;
            this.symbol = symbol;

            this.random = new Random();
        }

        public Point CreateFood()
        {
            return new Point(random.Next(2, x_max - 2), random.Next(2, y_max - 2), symbol);
        }
    }
}
