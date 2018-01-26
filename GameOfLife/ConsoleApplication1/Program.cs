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
            Cell cell2 = new Cell();
            Cell cell3 = new Cell();
            Cell cell4 = new Cell().StartLife();
            Cell cell5 = new Cell().StartLife();
            Cell cell6 = new Cell().StartLife();
            Cell cell7 = new Cell();
            Cell cell8 = new Cell();
            Cell cell9 = new Cell();
            
            //populate world
            matrix[0][0] = cell1.SetPosition(0,0);
            matrix[0][1] = cell2.SetPosition(0,1);
            matrix[0][2] = cell3.SetPosition(0,2);
            matrix[1][0] = cell4.SetPosition(1,0);
            matrix[1][1] = cell5.SetPosition(1,1);
            matrix[1][2] = cell6.SetPosition(1,2);
            matrix[2][0] = cell7.SetPosition(2,0);
            matrix[2][1] = cell8.SetPosition(2,1);
            matrix[2][2] = cell9.SetPosition(2,2);

            //T
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j].IsLive)
                        Console.Write(vivo);
                    if (!matrix[i][j].IsLive)
                        Console.Write(morto);
                    matrix[i][j].ControllaVicini(matrix);
                    ////sopra
                    //matrix[i][j].controllaVicini(matrix, i-1, j, "sopra");
                    ////sotto
                    //matrix[i][j].controllaVicini(matrix, i+1, j, "sotto");
                    ////sin
                    //matrix[i][j].controllaVicini(matrix, i, j-1, "sin");
                    ////dest
                    //matrix[i][j].controllaVicini(matrix, i, j+1, "dest");
                    ////diagonale sin sopra
                    //matrix[i][j].controllaVicini(matrix, i-1, j-1, "diagonale sin sopra");
                    ////diagonale sin sotto
                    //matrix[i][j].controllaVicini(matrix, i+1, j-1, "diagonale sin sotto");
                    ////diagonale des sopra
                    //matrix[i][j].controllaVicini(matrix, i-1, j+1, "diagonale des sopra");
                    ////diagonale des sotto
                    //matrix[i][j].controllaVicini(matrix, i+1, j+1, "diagonale des sotto");
                }
                Console.WriteLine();
            }

            //T+1
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    matrix[i][j] = matrix[i][j].Update();

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
