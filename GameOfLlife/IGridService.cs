namespace GameOfLlife
{
    public interface IGridService
    {
        char[,] GetFirstGenerationGridData();
        void DisplayGrid(char[,] array);
        char[,] WriteNextGenerationGridData();
    }
}