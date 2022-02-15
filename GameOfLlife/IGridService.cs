namespace GameOfLlife
{
    public interface IGridService
    {
        bool[,] GetFirstGenerationGridData();
        void DisplayGrid(char[,] array);
        void WriteNextGenerationGridData(char[,] nextGeneration);
    }
}