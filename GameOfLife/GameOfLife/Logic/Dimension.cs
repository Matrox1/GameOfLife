using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Logic
{
    class Dimension
    {
        private int width;
        public int Width { get { return width; } }
        private int height;
        public int Height { get { return height; } }
        private int size;
        public int Size { get { return size; } }
        public Dimension(int weight, int height)
        {
            this.width = weight;
            this.height = height;
            size = height * weight;
        }

        public static bool operator ==(Dimension firstDim, Dimension secondDim)
        {
            return  firstDim.Width == secondDim.Width && firstDim.Height == secondDim.Height;
        }
        public static bool operator !=(Dimension firstDim, Dimension secondDim)
        {
            return firstDim.Width != secondDim.Width || firstDim.Height != secondDim.Height;
        }
    }
}
