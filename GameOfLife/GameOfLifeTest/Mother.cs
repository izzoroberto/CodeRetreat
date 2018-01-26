using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

namespace GameOfLifeTest
{
   public class Mother
    {
        public static Cell[][] CreateMatrix3x3()
        {
            //create world at T
            Cell[][] matrix = new Cell[3][];
            matrix[0] = new Cell[3];
            matrix[1] = new Cell[3];
            matrix[2] = new Cell[3];
            return matrix;
        }

    }
}
