using System;
using System.Linq;

namespace P02.HelpA_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int initPoints = 25;

            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            //fill the matrix
            FillTheMatrix(n, matrix);

            int points = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine("Too bad! The Mole lost this battle!");
                    Console.WriteLine($"The Mole lost the game with a total of {points} points.");
                    break;
                }
                (int row, int col) = Position(matrix);
                //break if officer leaves the armory
                if ((row, col) == (100, 100))
                {
                    break;
                }


                if (command == "up")
                {
                    points += Move(row, col, row - 1, col, matrix);
                }
                else if (command == "down")
                {
                    points += Move(row, col, row + 1, col, matrix);
                }
                else
                if (command == "right")
                {
                    points += Move(row, col, row, col + 1, matrix);

                }
                else if (command == "left")
                {
                    points += Move(row, col, row, col - 1, matrix);
                }
                if (points >= initPoints)
                {  //break if officer bays swords worth at least 65 gold
                    Console.WriteLine("Yay! The Mole survived another game!");
                    Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
                    break;
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write(String.Join("", matrix[row, col]));
                Console.WriteLine();
            }
        }

        static (int row, int col) Position(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'M')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //something went wrong
        }

        static int Move(int row, int col, int newRow, int newCol, char[,] matrix)
        {
            if (0 > newRow ||
                0 > newCol ||
                matrix.GetLength(0) <= newRow ||
                matrix.GetLength(1) <= newCol)
            {
                Console.WriteLine("Don't try to escape the playing field!");

                return 0;
            }
            matrix[row, col] = '-';
            char points = matrix[newRow, newCol];
            matrix[newRow, newCol] = 'M';


            if (char.IsDigit(points))
            {
                return points - '0';
            }
            else if (points == 'S')
            {
                matrix[newRow, newCol] = '-';
                (int teleportedRow, int teleportedCol) = Teleport(matrix);
                matrix[teleportedRow, teleportedCol] = 'M';

                return -3;
            }

            return 0;
        }

        static (int row, int col) Teleport(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'S')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //something went wrong
        }
        static void FillTheMatrix(int n, char[,] matrix)
        {
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
        }
    }
}