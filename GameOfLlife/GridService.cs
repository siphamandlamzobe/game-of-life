using System.Text;

namespace GameOfLlife
{
    public class GridService : IGridService
    {
        private readonly IFileService _fileService;
        public GridService(IFileService fileService)
        {
            _fileService = fileService;
        }
        
        public GridService() : this(new FileService())
        {

        }

        public char[,] GetFirstGenerationGridData()
        {
            return _fileService.GetData();
        }

        public void DisplayGrid(char[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int x = 0; x <= array.GetUpperBound(1); x++)
                {
                    Console.Write(array[i, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void WriteNextGenerationGridData(char[,] nextGeneration)
        {
            _fileService.WriteToFile(nextGeneration);
        }
    }
}