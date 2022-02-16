namespace GameOfLife
{
    public interface IGameRulesService
    {
        char UpdateLiveCells(char[,] nextGeneration, int numberOfliveCells, int row, int col);
        char UpdateDeadCells(char[,] nextGeneration, int numberOfliveCells, int row, int col);
    }
}
