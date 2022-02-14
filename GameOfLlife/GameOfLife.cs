using System.Text;

namespace GameOfLlife
{
    public class GameOfLife : IGameOfLife
    {
        private readonly IGridService _gridService;
        

        public GameOfLife() : this(new GridService())
        {

        }
        
        public GameOfLife(IGridService gridService)
        {
            _gridService = gridService;
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
                    var elementNeighbors = FindNeighbours(firstGeneration,  i, x);
                    if (element.Equals('*'))
                    {
                        switch (FindNumberOfLiveOrDeadNeighbours(elementNeighbors, '*'))
                        {
                            case 1:
                                nextGeneration[i, x] = '.';
                                break;
                            case 4:
                                nextGeneration[i, x] = '.';
                                break;
                            case 2 or 3:
                                nextGeneration[i, x] = '*';
                                break;
                        }
                    }
                    else
                    {
                        switch (FindNumberOfLiveOrDeadNeighbours(elementNeighbors, '*'))
                        {
                            case 3:
                                nextGeneration[i, x] = '*';
                                break;
                            default:
                                nextGeneration[i, x] = '.';
                                break;
                        }
                    }
                    
                }
            }
            _gridService.DisplayGrid(nextGeneration);
            return nextGeneration;
        }

        public int FindNumberOfLiveOrDeadNeighbours(string neighbors, char state)
        {

            int freq = 0;
            foreach (char c in neighbors)
            {
                if (c == state)
                {
                    freq++;
                }
            }
            return freq;
        }

        public string FindNeighbours(char[,] firstGeneration, int row, int col)
        {
            var str = new StringBuilder();
            var row_limit = firstGeneration.GetLength(0) -1;
            if (row_limit > 0)
            {
                var column_limit = firstGeneration.GetLength(0);
                for (var x = Math.Max(0, row - 1); x <= Math.Min(row + 1, row_limit); x++)
                {
                    for (var y = Math.Max(0, col - 1); y <= Math.Min(col + 1, column_limit); y++)
                    {
                        if (x != row || y != col)
                        {
                            str.Append(firstGeneration[x,y]);
                        }
                    }
                }
            }
            return str.ToString();
        }
    }
}