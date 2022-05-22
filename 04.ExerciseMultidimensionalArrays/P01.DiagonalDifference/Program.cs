using System;
using System.Linq;

namespace P01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                int[] number = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int col = 0; col < n; col++)
                {

                    matrix[row, col] = number[col];
                }
                
            }
            int sumPrimalDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumPrimalDiagonal += matrix[row, col];
                    }
                    if (row + col == n - 1)
                    {
                        sumSecondaryDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimalDiagonal - sumSecondaryDiagonal));
        }
    }
}
