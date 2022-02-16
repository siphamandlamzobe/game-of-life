using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class NeighboursService : INeighboursService
    {
        public bool[] FindNeighbours(bool[,] firstGeneration, int row, int col)
        {
            var neighboursArray = new bool[8];

            var rowLimit = firstGeneration.GetLength(0) - 1;

            if (rowLimit > 0)
            {
                var columnLimit = firstGeneration.GetLength(0);
                int i = 0;
                for (var x = Math.Max(0, row - 1); x <= Math.Min(row + 1, rowLimit); x++)
                {
                    for (var y = Math.Max(0, col - 1); y <= Math.Min(col + 1, columnLimit); y++)
                    {
                        if (x != row || y != col)
                        {
                            neighboursArray[i] = firstGeneration[x, y];
                            i++;
                        }
                    }
                }
            }

            return neighboursArray;
        }

        public int FindNumberOfLiveNeighbours(bool[] neighbours)
        {
            int freq = 0;

            foreach (var neighbour in neighbours)
            {
                if (neighbour)
                {
                    freq++;
                }
            }

            return freq;
        }
    }
}
