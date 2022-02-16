namespace GameOfLife
{
    public interface INeighboursService
    {
        int FindNumberOfLiveNeighbours(bool[] neighbors);
        bool[] FindNeighbours(bool[,] firstGeneration, int row, int col);
    }
}
