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

        public char[,] GetNextGeneration()
        {
            var firstGeneration = _gridService.GetFirstGenerationGridData();

            var nextGeneration = new char[firstGeneration.GetLength(0), firstGeneration.GetLength(1)];

            for (int i = 0; i <= firstGeneration.GetUpperBound(0); i++)
            {
                for (int x = 0; x <= firstGeneration.GetUpperBound(1); x++)
                {
                    var elementNeighbors = _neighboursService.FindNeighbours(firstGeneration,  i, x);

                    int numberOfliveCells = _neighboursService.FindNumberOfLiveNeighbours(elementNeighbors);

                    if (firstGeneration[i, x])
                    {
                        nextGeneration[i, x] = _gameRulesService.UpdateLiveCells(nextGeneration, numberOfliveCells,i,x);
                    }
                    else
                    {
                        nextGeneration[i, x] = _gameRulesService.UpdateDeadCells(nextGeneration, numberOfliveCells, i, x);
                    }
                }
            }

            _gridService.WriteNextGenerationGridData(nextGeneration);

            _gridService.DisplayGrid(nextGeneration);

            return nextGeneration;
        }
    }
}