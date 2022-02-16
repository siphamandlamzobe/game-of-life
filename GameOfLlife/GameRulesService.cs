using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameRulesService : IGameRulesService
    {
        public char UpdateDeadCells(char[,] nextGeneration, int numberOfliveCells, int row, int col)
        {
            if (numberOfliveCells == 3)
            {
                return nextGeneration[row, col] = '*';
            }

            return nextGeneration[row, col] = '.';
        }

        public char UpdateLiveCells(char[,] nextGeneration, int numberOfliveCells, int row, int col)
        {
            if(numberOfliveCells == 1 || numberOfliveCells > 3)
            {
                return nextGeneration[row, col] = '.';
            }
            
            if (numberOfliveCells == 2 || numberOfliveCells == 3)
            {
                return nextGeneration[row, col] = '*';
            }

            return nextGeneration[row, col] = '.';
        }
    }
}
