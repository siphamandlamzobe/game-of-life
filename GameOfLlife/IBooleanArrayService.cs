namespace GameOfLife
{
    public interface IBooleanArrayService
    {
        bool[,] ConvertToBooleanArray(string[] rows, int rowLength, int rowCount);
    }
}
