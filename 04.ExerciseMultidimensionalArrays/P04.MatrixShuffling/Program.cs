﻿using System;
using System.Linq;

namespace P04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dimensions = Console.ReadLine();
            int rowsCount = int.Parse(dimensions.Split()[0]);
            int columnsCount = int.Parse(dimensions.Split()[1]);

            string[,] matrix = new string[rowsCount, columnsCount];
            //Fill the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                if (!Validate(cmd, rowsCount, columnsCount))
                {
                    Console.WriteLine("Invalid input!");
                    cmd = Console.ReadLine();
                    continue;
                }
                else
                {
                    int row1 = int.Parse(cmd.Split()[1]);
                    int col1 = int.Parse(cmd.Split()[2]);
                    int row2 = int.Parse(cmd.Split()[3]);
                    int col2 = int.Parse(cmd.Split()[4]);

                    string element1 = matrix[row1, col1];
                    string element2 = matrix[row2, col2];

                    matrix[row2, col2] = element1;
                    matrix[row1, col1] = element2;

                    for (int row = 0; row < rowsCount; row++)
                    {
                        for (int col = 0; col < columnsCount; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                cmd = Console.ReadLine();
            }

        }

        static bool Validate(string cmd, int rowsCount, int colsCount)
        {
            string[] cmdParts = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            if (cmd.Contains("swap") && cmdParts.Length == 5)
            {
                int row1 = int.Parse(cmdParts[1]);
                int col1 = int.Parse(cmdParts[2]);
                int row2 = int.Parse(cmdParts[3]);
                int col2 = int.Parse(cmdParts[4]);
                if (row1 >= 0 && row1 < rowsCount &&
                    col1 >= 0 && col1 < colsCount &&
                    row2 >= 0 && col2 < colsCount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}