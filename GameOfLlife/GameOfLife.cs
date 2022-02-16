using GameOfLife;
using System.Text;

namespace GameOfLlife
{
    public class GameOfLife
    {
        private IGridService _gridService;
        private INeighboursService _neighboursService;
        private IGameRulesService _gameRulesService;

        public GameOfLife(IGridService gridService, INeighboursService neighboursService, IGameRulesService gameRulesService)
        {
            _gridService = gridService;
            _neighboursService = neighboursService;
            _gameRulesService = gameRulesService;
        }

        public char[,] GetNextGeneration(string fileName)
        {
            var firstGeneration = _gridService.GetFirstGenerationGridData(fileName);

            var nextGeneration = new char[firstGeneration.GetLength(0), firstGeneration.GetLength(1)];

            for (int i = 0; i <= firstGeneration.GetUpperBound(0); i++)
            {
                for (int x = 0; x <= firstGeneration.GetUpperBound(1); x++)
                {
                    BuildNextGeneration(firstGeneration, nextGeneration, i, x);
                }
            }

            _gridService.WriteNextGenerationGridData(nextGeneration);

            _gridService.DisplayGrid(nextGeneration);

            return nextGeneration;
        }

        private char BuildNextGeneration(bool[,] firstGeneration, char[,] nextGeneration, int row, int column)
        {
            var elementNeighbors = _neighboursService.FindNeighbours(firstGeneration, row, column);

            int numberOfliveCells = _neighboursService.FindNumberOfLiveNeighbours(elementNeighbors);

            if (firstGeneration[row, column])
            {
                return nextGeneration[row, column] = _gameRulesService.UpdateLiveCells(nextGeneration, numberOfliveCells, row, column);
            }
            else
            {
                return nextGeneration[row, column] = _gameRulesService.UpdateDeadCells(nextGeneration, numberOfliveCells, row, column);
            }
        }
    }
}