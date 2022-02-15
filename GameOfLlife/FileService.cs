using System.Text;
using System.Text.RegularExpressions;

namespace GameOfLlife
{
    public class FileService : IFileService
    {
        private string _directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public bool[,] GetData()
        {
            var rows = GetFileDataRows();

            int rowLength = rows[0].Length;
            int rowCount = rows.Length;

            return ConvertToBooleanArray(rows,rowLength, rowCount);
        }

        public char[,] GenereteFirstGenerationArray(string[] rows, int rowLength, int rowCount)
        {
            char[,] firstGeneration = new char[rowCount, rowLength];

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    firstGeneration[i, j] = rows[i][j];
                }
                Console.WriteLine();
            }
            return firstGeneration;
        }

        public string[] GetFileDataRows()
        {
            var filePath = Path.Combine(_directory, @"Generation1.txt");

            string fileContent = File.ReadAllText(filePath);

            string replacement = Regex.Replace(fileContent, @"\t|\n|\r", "");

            return replacement.Split(' ');
        }

        public void WriteToFile(char[,] nextGeneration)
        {
            StreamWriter streamWriter = new StreamWriter(_directory +@"\NextGeneration\\NextGeneration.txt");

            var output = new StringBuilder();

            for (int i = 0; i <= nextGeneration.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= nextGeneration.GetUpperBound(1); j++)
                {
                    output.Append(nextGeneration[i, j]);
                }
                streamWriter.WriteLine(output.ToString());
                output.Clear();
            }
            streamWriter.Close();
        }

        public bool[,] ConvertToBooleanArray(string[] rows, int rowLength, int rowCount)
        {
            var dot = '.';
            bool[,] firstGeneration = new bool[rowCount, rowLength];

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if(rows[i][j] == dot)
                    {
                        firstGeneration[i, j] = false;
                    }
                    else
                    {
                        firstGeneration[i, j] = true;
                    }
                }
                Console.WriteLine();
            }
            return firstGeneration;
        }

    }
}