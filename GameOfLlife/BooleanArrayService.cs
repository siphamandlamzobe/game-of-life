using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class BooleanArrayService : IBooleanArrayService
    {
        public bool[,] ConvertToBooleanArray(string[] rows, int rowLength, int rowCount)
        {
            var dot = '.';
            bool[,] firstGeneration = new bool[rowCount, rowLength];

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (rows[i][j] == dot)
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
