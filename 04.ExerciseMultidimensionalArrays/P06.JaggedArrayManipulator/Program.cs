using System;
using System.Linq;

namespace P06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rowsCount - 1; row++)
            {
                if (matrix[row].Length  == matrix[row+1].Length)
                {
                    matrix[row] = matrix[row].Select(element => element * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(element => element * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(element => element / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(element => element / 2).ToArray();
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                int row = int.Parse(cmd.Split()[1]);
                int col = int.Parse(cmd.Split()[2]);
                int value = int.Parse(cmd.Split()[3]);

                if (cmd.StartsWith("Add"))
                {
                    if (row >= 0 && row < rowsCount && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (cmd.StartsWith("Subtract"))
                {
                    if (row >= 0 && row < rowsCount && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }

                cmd = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
