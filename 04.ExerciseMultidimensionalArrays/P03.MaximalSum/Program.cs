using System;
using System.Linq;

namespace P03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dimencions = Console.ReadLine();
            int rowsCount = int.Parse(dimencions.Split()[0]);
            int colsCount = int.Parse(dimencions.Split()[1]);

            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int[,] square3x3Matrix = new int[3, 3];
            int maxSum = 0;
            int sum = 0;

            for (int row = 0; row < rowsCount - 2; row++)
            {

                for (int col = 0; col < colsCount - 2; col++)
                {
                    square3x3Matrix[row, col] = matrix[row, col];
                    square3x3Matrix[row + 1, col] = matrix[row + 1, col+1];
                    square3x3Matrix[row + 2, col] = matrix[row + 2, col+2];
                    sum += matrix[row, col] + matrix[row + 1, col+1] + matrix[row + 2, col+2];


                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    square3x3Matrix = new int[3, 3];

                }
                sum = 0;

            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < square3x3Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < square3x3Matrix.GetLength(1); col++)
                {
                    Console.Write(square3x3Matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
