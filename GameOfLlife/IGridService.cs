namespace GameOfLlife
{
    public interface IGridService
    {
        bool[,] GetFirstGenerationGridData(string fileName);
        void DisplayGrid(char[,] array);
        void WriteNextGenerationGridData(char[,] nextGeneration);
    }
}