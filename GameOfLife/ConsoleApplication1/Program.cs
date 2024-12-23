﻿using System;
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

            //create cell and populate world!
            matrix[0][0] = new Cell().SetPosition(0, 0);
            matrix[0][1] = new Cell().SetPosition(0, 1);
            matrix[0][2] = new Cell().SetPosition(0, 2);
            matrix[1][0] = new Cell().StartLife().SetPosition(1, 0);
            matrix[1][1] = new Cell().StartLife().SetPosition(1, 1);
            matrix[1][2] = new Cell().StartLife().SetPosition(1, 2);
            matrix[2][0] = new Cell().SetPosition(2, 0);
            matrix[2][1] = new Cell().SetPosition(2, 1);
            matrix[2][2] = new Cell().SetPosition(2, 2);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    ShowWorld(matrix, i, j);
                }
                Console.WriteLine();
            }

            int count = 0;
            while (count < 5)
            {
                //T
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j].ControllaViciniVivi(matrix);
                    }
                    Console.WriteLine();
                }

                //T+1
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = matrix[i][j].Update();
                        ShowWorld(matrix, i, j);
                    }
                    Console.WriteLine();
                }
                count++;
            }
            Console.ReadLine();
        }

        private static void ShowWorld(Cell[][] matrix, int i, int j)
        {
            if (matrix[i][j].IsLive)
                Console.Write(vivo);
            if (!matrix[i][j].IsLive)
                Console.Write(morto);
        }
    }
}
