using System;
using System.Linq;

namespace P02.WallDestroyer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            for (int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[0][c];
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();
                (int row, int col) = Position(matrix);

                if (cmd == "End")
                {
                    break;
                }
                else if (cmd == "up")
                {
                    Move(row, col, row - 1, col, matrix);
                    if (IsThereElecetrycity(matrix, row, col, row - 1, col) == true)
                    {
                        break;
                    }
                }
                else if (cmd == "down")
                {
                    Move(row, col, row + 1, col, matrix);
                    if (IsThereElecetrycity(matrix, row, col, row + 1, col) == true)
                    {
                        break;
                    }
                }
                else if (cmd == "left")
                {
                    Move(row, col, row, col - 1, matrix);
                    if (IsThereElecetrycity(matrix, row, col, row, col - 1) == true)
                    {
                        break;
                    }
                }
                else if (cmd == "right")
                {
                    Move(row, col, row, col + 1, matrix);
                    if (IsThereElecetrycity(matrix, row, col, row, col + 1) == true)
                    {
                        break;
                    }
                }
                if (row == 100 && col == 100)
                {
                    break;
                }
            }
        }



        static void Move(int row, int col, int newRow, int newCol, char[,] matrix)
        {
            if (IsThereRods(matrix, row, col, newRow, newCol))
            {
                return;
            }


            else if (IsThereHole(matrix, row, col, newRow, newCol))
            {
                
            }

                matrix[row, col] = '*';
                matrix[newRow, newCol] = 'V';
            

        }

        static bool IsThereHole(char[,] matrix, int row, int col, int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position [{newRow}, {newCol}]!");
                return true;
            }
            return false;
        }

        static int CountOfHoles(char[,] matrix)
        {
            int counter = 0;
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == '*')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static bool IsThereElecetrycity(char[,] matrix, int row, int col, int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'C')
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {CountOfHoles(matrix)+1} hole(s).");
                matrix[row, col] = '*';
                matrix[newRow, newCol] = 'E';
                return true;
            }
            return false;
        }
        static bool IsThereRods(char[,] matrix, int row, int col, int newRow, int newCol)
        {
            if (matrix[newRow, newCol] == 'R')
            {
                Console.WriteLine("Vanko hit a rod!");
                return true;
            }
            return false;
        }
        static (int row, int col) Position(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'V')
                    {
                        return (r, c);
                    }
                }
            }
            throw new Exception("Vanko is missing");
        }
    }
}
