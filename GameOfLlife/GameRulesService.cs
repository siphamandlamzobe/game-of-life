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
            switch (numberOfliveCells)
            {
                case int val when val == 3:
                    return nextGeneration[row, col] = '*';
                    
                default:
                    return nextGeneration[row, col] = '.';
            }
        }

        public char UpdateLiveCells(char[,] nextGeneration, int numberOfliveCells, int row, int col)
        {
            switch (numberOfliveCells)
            {
                case int val when val == 1 || val > 3:
                    return nextGeneration[row, col] = '.';

                case int val when val == 2 || val == 3:
                    return nextGeneration[row, col] = '*';

                default:
                    return nextGeneration[row, col] = '.';
            }
        }
    }
}
