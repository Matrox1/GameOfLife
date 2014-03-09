using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Logic;
using System.Windows;

namespace GameOfLife
{
    class LifeModel
    {
        LifeBoard lifeBoard;
        Dimension dim;

        private const bool ALIVE = true;
        private const bool DEAD = false;


        public LifeModel(Dimension dim)
        {
            this.dim = dim;
            lifeBoard = new LifeBoard(this.dim);
        }
        public void InitialGeneration(List<Point> initialPoints)
        {
            foreach (var point in initialPoints)
            {
                int x = Convert.ToInt32(point.X);
                int y = Convert.ToInt32(point.Y);
                lifeBoard[x, y] = true;
            }
        }

        public void NextStep()
        {
            LifeBoard newLifeBoard = new LifeBoard(this.dim);
            for (int i = 0; i < dim.Width; i++)
            {
                for (int j = 0; j < dim.Height; j++)
                {

                    if (IsCurrentCellAlive(i, j))
                    {
                        int currCellAliveNeighbors = CalculateAliveNeighbors(i, j);

                        if (currCellAliveNeighbors < 2) //less then 2 - become dead
                        {
                            newLifeBoard[i, j] = DEAD;
                        }
                        else if (currCellAliveNeighbors >= 4) // 4 or more - become dead
                        {
                            newLifeBoard[i, j] = DEAD;
                        }
                        else if (currCellAliveNeighbors == 2 || currCellAliveNeighbors == 3) //exactly 2 or 3 - become alive
                        {
                            newLifeBoard[i, j] = ALIVE;
                        }
                    }
                    else
                    {
                        if (CalculateAliveNeighbors(i, j) == 3)
                        {
                            newLifeBoard[i, j] = ALIVE;
                        }
                        else
                        {
                            newLifeBoard[i, j] = DEAD;
                        }
                    }
                }
            }
        }

        private int CalculateAliveNeighbors(int x, int y)
        {
            int aliveNeighbors = 0;

            if (lifeBoard[x - 1, y - 1])
                aliveNeighbors++;
            if (lifeBoard[x, y - 1])
                aliveNeighbors++;
            if (lifeBoard[x + 1,y - 1])
                aliveNeighbors++;
            if (lifeBoard[x - 1,y])
                aliveNeighbors++;
            if (lifeBoard[x + 1, y])
                aliveNeighbors++;
            if (lifeBoard[x - 1, y + 1])
                aliveNeighbors++;
            if (lifeBoard[x, y + 1])
                aliveNeighbors++;
            if (lifeBoard[x + 1, y + 1])
                aliveNeighbors++;

            return aliveNeighbors;
        }

        private bool IsCurrentCellAlive(int x, int y)
        {
            return lifeBoard[x, y] == ALIVE;
        }
    }
}
