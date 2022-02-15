using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface IGameRulesService
    {
        char UpdateLiveCells(char[,] nextGeneration, int numberOfliveCells, int row, int col);
        char UpdateDeadCells(char[,] nextGeneration, int numberOfliveCells, int row, int col);
    }
}
