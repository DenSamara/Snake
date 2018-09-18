using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Wall : Figure
    {
        List<Figure> walls;

        public Wall(int mapWidth, int mapHeight)
        {
            walls = new List<Figure>();

            //Верх
            HorizontalLine upFrame = new HorizontalLine(1, 1, mapWidth, '+');
            //Низ
            HorizontalLine downFrame = new HorizontalLine(1, mapHeight - 1, mapWidth, '+');
            //Лево
            VerticalLine leftFrame = new VerticalLine(1, 1, mapHeight, '+');
            //Право
            VerticalLine rightFrame = new VerticalLine(mapWidth - 1, 1, mapHeight, '+');

            walls.Add(upFrame);
            walls.Add(downFrame);
            walls.Add(leftFrame);
            walls.Add(rightFrame);
        }

        public void Draw(){
            foreach (var item in walls)
            {
                item.Draw();
            }
        }

        public bool isHit(Figure figure)
        {
            foreach (Figure item in walls)
            {
                if (item.isHit(figure))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
