using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface INeighboursService
    {
        int FindNumberOfLiveNeighbours(bool[] neighbors);
        bool[] FindNeighbours(bool[,] firstGeneration, int row, int col);
    }
}
