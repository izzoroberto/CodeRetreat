using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsLive { get; set; }
        public int viciniVivi { get; set; }

        public Cell update()
        {
            if (viciniVivi < 2 || viciniVivi > 3)
            {
                Cell c = new Cell();
                c.IsLive = false;
                return c;
            }
            if (!IsLive && viciniVivi == 3)
            {
                Cell c = new Cell();
                c.IsLive = true;
                return c;
            }
            return this;
        }

        public int controllaVicini(Cell[][] matrix, int x, int y, string debug)
        {
            try
            {
                viciniVivi = matrix[x][y].IsLive ? viciniVivi + 1 : viciniVivi;
            }
            catch (System.IndexOutOfRangeException)
            {
                viciniVivi = viciniVivi;
            }
            return viciniVivi;
        }
    }
}
