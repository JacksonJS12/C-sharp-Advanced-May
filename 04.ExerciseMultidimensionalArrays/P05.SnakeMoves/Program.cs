
using System;

namespace P05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rowsCount = int.Parse(input.Split()[0]); //N
            int colsCount = int.Parse(input.Split()[1]); //M

            char[,]matrix = new char[rowsCount, colsCount];
            string snake = Console.ReadLine();
            int index = 0;
            for (int row = 0; row < rowsCount; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < colsCount; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = colsCount - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
