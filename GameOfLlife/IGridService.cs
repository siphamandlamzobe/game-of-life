namespace GameOfLlife
{
    public interface IGridService
    {
        char[,] GetFirstGenerationGridData();
        void DisplayGrid(char[,] array);
        void WriteNextGenerationGridData(char[,] nextGeneration);
    }
}