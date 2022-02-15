using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class NeighboursService : INeighboursService
    {
        public NeighboursService()
        {

        }
        public string FindNeighbours(char[,] firstGeneration, int row, int col)
        {
            var neighboursString = new StringBuilder();
            var rowLimit = firstGeneration.GetLength(0) - 1;
            if (rowLimit > 0)
            {
                var columnLimit = firstGeneration.GetLength(0);
                for (var x = Math.Max(0, row - 1); x <= Math.Min(row + 1, rowLimit); x++)
                {
                    for (var y = Math.Max(0, col - 1); y <= Math.Min(col + 1, columnLimit); y++)
                    {
                        if (x != row || y != col)
                        {
                            neighboursString.Append(firstGeneration[x, y]);
                        }
                    }
                }
            }
            return neighboursString.ToString();
        }

        public int FindNumberOfLiveNeighbours(string neighbors)
        {
            int freq = 0;
            foreach (char c in neighbors)
            {
                if (c == '*')
                {
                    freq++;
                }
            }
            return freq;
        }
    }
}
