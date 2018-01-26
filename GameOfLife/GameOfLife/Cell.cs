using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        private int _x;
        private int _y;
        public bool IsLive { get; private set; }
        private int _viciniVivi { get; set; }

        public Cell  SetPosition(int x, int y)
        {
            this._x = x;
            this._y = y;
            return this;
        }


        public Cell Update()
        {
            if (_viciniVivi < 2 || _viciniVivi > 3)
            {
                Cell c = new Cell();
                c.IsLive = false;
                return c;
            }
            if (!IsLive && _viciniVivi == 3)
            {
                Cell c = new Cell();
                c.IsLive = true;
                return c;
            }
            return this;
        }

        public void ControllaVicini(Cell[][] matrix)
        {
            IsLife(matrix,_x-1, _y, "sopra");
            IsLife(matrix, _x + 1, _y, "sotto");
            IsLife(matrix, _x, _y-1, "sin");
            IsLife(matrix, _x-1, _y+1, "dest");
            IsLife(matrix, _x-1, _y-1, "diagonale sin sopra");
            IsLife(matrix, _x+1, _y-1, "diagonale sin sotto");
            IsLife(matrix, _x-1, _y+1, "diagonale des sopra");
            IsLife(matrix, _x+1, _y+1, "diagonale des sotto");
        }

        private void IsLife(Cell[][] matrix, int x, int y, string debug)
        {
            try
            {
                _viciniVivi = matrix[x][y].IsLive ? _viciniVivi + 1 : _viciniVivi;
            }
            catch (System.IndexOutOfRangeException)
            {
                _viciniVivi = _viciniVivi;
            }
        }

        public Cell StartLife()
        {
            IsLive = true;
            return this;
        }
    }
}
