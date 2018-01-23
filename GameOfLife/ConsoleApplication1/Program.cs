using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell[][] matrix = new Cell[3][];
            matrix[0] = new Cell[3];
            matrix[1] = new Cell[3];
            matrix[2] = new Cell[3];
            Cell cell1 = new Cell();
            cell1.IsLive = true;
            Cell cell2 = new Cell();
            cell2.IsLive = true;
            Cell cell3 = new Cell();
            cell3.IsLive = true;
            Cell cell4 = new Cell();
            cell4.IsLive = true;
            Cell cell5 = new Cell();
            cell5.IsLive = false;
            Cell cell6 = new Cell();
            cell6.IsLive = true;
            Cell cell7 = new Cell();
            cell7.IsLive = true;
            Cell cell8 = new Cell();
            cell8.IsLive = true;
            Cell cell9 = new Cell();
            cell9.IsLive = true;
            matrix[0][0] = cell1;
            matrix[0][1] = cell2;
            matrix[0][2] = cell3;
            matrix[1][0] = cell4;
            matrix[1][1] = cell5;
            matrix[1][2] = cell6;
            matrix[2][0] = cell7;
            matrix[2][1] = cell8;
            matrix[2][2] = cell9;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    string morto = "X";
                    string vivo = "O";

                    if (matrix[i][j].IsLive)
                        Console.Write(vivo);
                    if (!matrix[i][j].IsLive)
                        Console.Write(morto);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
