using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface IBooleanArrayService
    {
        bool[,] ConvertToBooleanArray(string[] rows, int rowLength, int rowCount);
    }
}
