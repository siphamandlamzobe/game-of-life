namespace GameOfLlife
{
    public interface IFileService
    {
        bool[,] GetData();
        void WriteToFile(char[,] nextGeneration);
    }
}