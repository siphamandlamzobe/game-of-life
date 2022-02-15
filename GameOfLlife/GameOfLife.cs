using GameOfLife;
using System.Text;

namespace GameOfLlife
{
    public class GameOfLife : IGameOfLife
    {
        private readonly IGridService _gridService;
        private readonly INeighboursService _neighboursService;

        public GameOfLife() : this(new GridService(), new NeighboursService())
        {

        }
        
        public GameOfLife(IGridService gridService, INeighboursService neighboursService)
        {
            _gridService = gridService;
            _neighboursService = neighboursService;
        }

        public char[,] GetNextGeneration()
        {
            var firstGeneration = _gridService.GetFirstGenerationGridData();
            var nextGeneration = new char[firstGeneration.GetLength(0), firstGeneration.GetLength(1)];
            for (int i = 0; i <= firstGeneration.GetUpperBound(0); i++)
            {
                for (int x = 0; x <= firstGeneration.GetUpperBound(1); x++)
                {
                    var element = firstGeneration[i, x];
                    var elementNeighbors = _neighboursService.FindNeighbours(firstGeneration,  i, x);
                    int numberOfLives = _neighboursService.FindNumberOfLiveNeighbours(elementNeighbors);
                    if (element.Equals('*'))
                    {
                        switch (numberOfLives)
                        {
                            case int val when val == 1 || val > 3:
                                nextGeneration[i, x] = '.';
                                break;
                            case int val when val == 2 || val == 3:
                                nextGeneration[i, x] = '*';
                                break;
                            default:
                                nextGeneration[i, x] = '.';
                                break;
                        }
                    }
                    else
                    {
                        switch (numberOfLives)
                        {
                            case int val when val == 3:
                                nextGeneration[i, x] = '*';
                                break;
                            default:
                                nextGeneration[i, x] = '.';
                                break;
                        }
                    }
                    
                }
            }
            _gridService.WriteNextGenerationGridData(nextGeneration);
            return nextGeneration;
        }
    }
}