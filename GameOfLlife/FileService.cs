using GameOfLife;
using System.Text;
using System.Text.RegularExpressions;

namespace GameOfLlife
{
    public class FileService : IFileService
    {
        private string _directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private readonly IBooleanArrayService _booleanArrayService;

        public FileService(IBooleanArrayService booleanArrayService)
        {
            _booleanArrayService = booleanArrayService;
        }

        public FileService() : this(new BooleanArrayService())
        {
        }

        public bool[,] GetData(string fileName)
        {
            var rows = GetFileDataRows(fileName);

            int rowLength = rows[0].Length;
            int rowCount = rows.Length;

            return _booleanArrayService.ConvertToBooleanArray(rows,rowLength, rowCount);
        }

        private string[] GetFileDataRows(string fileName)
        {
            var filePath = Path.Combine(_directory, fileName);

            string fileContent = File.ReadAllText(filePath);

            string replacement = Regex.Replace(fileContent, @"\t|\n|\r", "");

            return replacement.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        public void WriteToFile(char[,] nextGeneration)
        {
            StreamWriter streamWriter = new StreamWriter(_directory +@"\NextGeneration\\NextGeneration.txt");

            var stringBuilder = new StringBuilder();

            for (int i = 0; i <= nextGeneration.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= nextGeneration.GetUpperBound(1); j++)
                {
                    stringBuilder.Append(nextGeneration[i, j]);
                }
                streamWriter.WriteLine(stringBuilder.ToString());
                stringBuilder.Clear();
            }
            streamWriter.Close();
        }
    }
}