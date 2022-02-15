namespace GameOfLlife
{
    public interface IFileService
    {
        Char[,] GetData();
        void WriteToFile(char[,] nextGeneration);
    }
}