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

        public void update()
        {
            if (viciniVivi < 2 || viciniVivi > 3)
                IsLive = false;
            if (!IsLive && viciniVivi == 3)
                IsLive = true;
        }
    }
}
