using System;
using System.Linq;

namespace P02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rowsCount = int.Parse(dimensions[0]);
            int columnsCount = int.Parse(dimensions[1]);

            string[,] matrix = new string[rowsCount, columnsCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row + 1 < rowsCount && col + 1 < columnsCount)
                    {
                        if (matrix[row, col] == matrix[row, col + 1] &&
                            matrix[row, col] == matrix[row + 1, col] &&
                            matrix[row, col] == matrix[row, col + 1] &&
                            matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                }
            }
                Console.WriteLine(count);
        }
    }
}
