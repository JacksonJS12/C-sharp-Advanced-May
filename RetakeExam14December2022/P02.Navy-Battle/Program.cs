using System;
using System.Linq;
using System.Numerics;

namespace P02.Navy_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine()
                    .ToCharArray();

                matrix[i] = line;
            }

            int currRow = 0;
            int currCol = 0;

            int hits = 0;
            int cruiserCount = 0;
            while (true)
            {
                var cmd = Console.ReadLine();

                if (hits > 2 ||
                    cruiserCount == 3)
                {
                    break;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < rows; c++)
                    {
                        if (matrix[r][c] == 'S')
                        {
                            currRow = r;
                            currCol = c;
                        }
                    }
                }

                if (cmd == "up" && currRow - 1 >= 0)
                {
                    (hits, cruiserCount) = Move(currRow, currCol, matrix, hits, cruiserCount, currRow - 1, currCol);
                }
                else if (cmd == "down" && currRow + 1 <= rows)
                {
                    (hits, cruiserCount) = Move(currRow, currCol, matrix, hits, cruiserCount, currRow + 1, currCol);
                }
                else if (cmd == "left" && currCol - 1 >= 0)
                {
                    (hits, cruiserCount) = Move(currRow, currCol, matrix, hits, cruiserCount, currRow, currCol - 1);
                }
                else if (cmd == "right" && currCol + 1 <= rows)
                {
                    (hits, cruiserCount) = Move(currRow, currCol, matrix, hits, cruiserCount, currRow, currCol + 1);
                }
            }

            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("", line));
            }
        }
        public static (int hits, int cruiserCount) Move(int currRow, int currCol, char[][] matrix, int hits, int cruiserCount, int newRow, int newCol)
        {
            if (matrix[newRow][newCol] == '*')
            {
                hits++;
                if (hits > 2)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{newRow}, {newCol}]!");
                }
            }
            else if (matrix[newRow][newCol] == 'C')
            {
                cruiserCount++;
                if (cruiserCount == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                }
            }

            matrix[newRow][newCol] = 'S';
            matrix[currRow][currCol] = '-';
            return (hits, cruiserCount);
        }
    }
}
