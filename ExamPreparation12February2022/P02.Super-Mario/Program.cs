
using System;
using System.Linq;

namespace P02.Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            int marioRow = default;
            int marioCol = default;
            for (int r = 0; r < rows; r++)
            {
                var currRow = Console.ReadLine()
                    .ToCharArray();
                matrix[r] = currRow;
                if (currRow.Contains('M'))
                {
                    marioRow = r;
                    marioCol = currRow
                        .ToList()
                        .IndexOf('M');
                }
            }

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                string cmd = tokens[0];
                int enemyRow = int.Parse(tokens[1]);
                int enemyCol = int.Parse(tokens[2]);

                matrix[enemyRow][enemyCol] = 'B';
                marioLives--;

                matrix[marioRow][marioCol] = '-';
                if (cmd == "W" && marioRow - 1 >= 0)
                {
                    marioRow--;
                } 
                else if (cmd == "S" && marioRow + 1 < rows)
                {
                    marioRow++;
                }
                else if (cmd == "A" && marioCol - 1 >= 0)
                {
                    marioCol--;
                }
                else if (cmd == "D" && marioCol + 1 < matrix[0].Length)
                {
                    marioCol++;
                }

                if (matrix[marioRow][marioCol] == 'B')
                {
                    marioLives -= 2;
                }
                else if (matrix[marioRow][marioCol] == 'P')
                {
                    matrix[marioRow][marioCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                    break;
                }

                if (marioLives <= 0)
                {
                    matrix[marioRow][marioCol] = 'X';
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    break;
                }

                matrix[marioRow][marioCol] = 'M';
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(new string(matrix[i]));
            }
        }
    }
}
