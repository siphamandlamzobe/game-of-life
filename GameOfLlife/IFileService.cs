namespace GameOfLlife
{
    public interface IFileService
    {
        bool[,] GetData(string fileName);
        void WriteToFile(char[,] nextGeneration);
    }
}