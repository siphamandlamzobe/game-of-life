using System.Text.RegularExpressions;

namespace GameOfLlife
{
    public class FileService : IFileService
    {
        public char[,] GetData()
        {
            //string directory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            string directory = "C:\\Dev\\Kata2\\GameOfLlife\\GameOfLlife";
            directory = Path.Combine(directory, @"Generation1.txt"); 

            string fileContent = File.ReadAllText(directory);

            string replacement = Regex.Replace(fileContent, @"\t|\n|\r", "");

            string[] rows = replacement.Split(' ');

            int rowLength = rows[0].Length;
            int rowCount = rows.Length;
            char[,] generation = new char[rowCount,rowLength];

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    generation[i, j] = rows[i][j];
                }
                Console.WriteLine();
            }

            return generation;
        }
    }
}