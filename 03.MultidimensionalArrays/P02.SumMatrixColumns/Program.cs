﻿
using System;
using System.Linq;

namespace P02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            (int rowsCount, int colsCount) = (dimensions[0], dimensions[1]);

            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            long[] colSums = new long[colsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    colSums[col] += matrix[row, col];
                }
            }

            for (int col = 0; col < colsCount; col++)
            {
                Console.WriteLine(colSums[col]);
            }
        }
    }
}
