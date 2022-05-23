using System;
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
                

                cmd = Console.ReadLine();
            }

        }

        static bool Validate(string cmd)
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
            }
        }
    }
}