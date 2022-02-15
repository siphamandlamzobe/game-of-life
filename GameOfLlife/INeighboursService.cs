using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface INeighboursService
    {
        int FindNumberOfLiveNeighbours(string neighbors);
        string FindNeighbours(char[,] firstGeneration, int row, int col);
    }
}
