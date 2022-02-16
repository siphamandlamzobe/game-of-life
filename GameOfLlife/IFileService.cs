namespace GameOfLife
{
    public interface IFileService
    {
        bool[,] GetData(string fileName);
        void WriteToFile(char[,] nextGeneration);
    }
}