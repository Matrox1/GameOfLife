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
        private BitArray[,] array;
        private int width;
        private int height;
        private int size;

        private const int NUMBER_OF_DIMENSIONS = 2;

        public LifeBoard(Dimension dim)
        {
            width = dim.Width;
            height = dim.Height;
            size = dim.Size;
            array = new BitArray[width, height];
        }

        public void Clear()
        {
            for (int i = 0; i < NUMBER_OF_DIMENSIONS; i++)
			{
                this.array[i, 0].SetAll(false);
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
                    //return array[x , y];
                }
            }
            set
            {
                if (x < 0 || x > width || y < 0 || y > height)
                    throw new IndexOutOfRangeException("Incorrect x or y.");    
                else
                {
                    //array[x, y].Set( = value;
                }
            }
        }

    }
}
