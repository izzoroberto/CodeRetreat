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
        static string morto = "X";
        static string vivo = "O";

        static void Main(string[] args)
        {
            //create world at T
            Cell[][] matrix = new Cell[3][];
            matrix[0] = new Cell[3];
            matrix[1] = new Cell[3];
            matrix[2] = new Cell[3];
            
            //create cell
            Cell cell1 = new Cell();
            cell1.IsLive = false;
            Cell cell2 = new Cell();
            cell2.IsLive = false;
            Cell cell3 = new Cell();
            cell3.IsLive = false;
            Cell cell4 = new Cell();
            cell4.IsLive = true;
            Cell cell5 = new Cell();
            cell5.IsLive = true;
            Cell cell6 = new Cell();
            cell6.IsLive = true;
            Cell cell7 = new Cell();
            cell7.IsLive = false;
            Cell cell8 = new Cell();
            cell8.IsLive = false;
            Cell cell9 = new Cell();
            cell9.IsLive = false;
            
            //populate world
            matrix[0][0] = cell1;
            matrix[0][1] = cell2;
            matrix[0][2] = cell3;
            matrix[1][0] = cell4;
            matrix[1][1] = cell5;
            matrix[1][2] = cell6;
            matrix[2][0] = cell7;
            matrix[2][1] = cell8;
            matrix[2][2] = cell9;

            //T
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j].IsLive)
                        Console.Write(vivo);
                    if (!matrix[i][j].IsLive)
                        Console.Write(morto);
                    //sopra
                    matrix[i][j].controllaVicini(matrix, i-1, j, "sopra");
                    //sotto
                    matrix[i][j].controllaVicini(matrix, i+1, j, "sotto");
                    //sin
                    matrix[i][j].controllaVicini(matrix, i, j-1, "sin");
                    //dest
                    matrix[i][j].controllaVicini(matrix, i, j+1, "dest");
                    //diagonale sin sopra
                    matrix[i][j].controllaVicini(matrix, i-1, j-1, "diagonale sin sopra");
                    //diagonale sin sotto
                    matrix[i][j].controllaVicini(matrix, i+1, j-1, "diagonale sin sotto");
                    //diagonale des sopra
                    matrix[i][j].controllaVicini(matrix, i-1, j+1, "diagonale des sopra");
                    //diagonale des sotto
                    matrix[i][j].controllaVicini(matrix, i+1, j+1, "diagonale des sotto");
                    //matrixT1[i][j] = matrix[i][j].update();
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    matrix[i][j] = matrix[i][j].update();


                    if (matrix[i][j].IsLive)
                        Console.Write(vivo);
                    if (!matrix[i][j].IsLive)
                        Console.Write(morto);
                  
                }
                Console.WriteLine();
            }

            ////T+1
            //for (int i = 0; i < matrixT1.Length; i++)
            //{
            //    for (int j = 0; j < matrixT1[i].Length; j++)
            //    {
            //        if (matrixT1[i][j].IsLive)
            //            Console.Write(vivo);
            //        if (!matrixT1[i][j].IsLive)
            //            Console.Write(morto);
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
