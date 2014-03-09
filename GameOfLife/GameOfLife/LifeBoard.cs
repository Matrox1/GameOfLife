using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GameOfLife.Logic;

namespace GameOfLife
{
    class LifeBoard
    {
        private bool[,] array;
        private int width;
        private int height;
        private int size;

        public LifeBoard(Dimension dim)
        {
            width = dim.Width;
            height = dim.Height;
            size = dim.Size;
            array = new bool[width, height];            
        }

        public void Clear()
        {
            for (int i = 0; i < width; i++)
			{
                for (int j = 0; j < height; j++)
                {
                    this.array[i, j] = false;                    
                }
			}
        }

        public void CopyTo(LifeBoard lifeBoard)
        {
            int width = Math.Min(this.width, lifeBoard.width);
            int height = Math.Min(this.height, lifeBoard.height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    lifeBoard[i, j] = this[i, j];
                }
            }
        }

        public bool this[int x, int y]
        {
            get
            {
                if (x < 0 || x > width || y < 0 || y > height)
                    throw new IndexOutOfRangeException("Incorrect x or y.");    
                else
                {
                    return array[x , y];
                }
            }
            set
            {
                if (x < 0 || x > width || y < 0 || y > height)
                    throw new IndexOutOfRangeException("Incorrect x or y.");    
                else
                {
                    array[x, y] = value;
                }
            }
        }

    }
}
