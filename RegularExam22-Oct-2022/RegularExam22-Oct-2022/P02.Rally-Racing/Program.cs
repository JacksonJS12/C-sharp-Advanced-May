using System;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace P02.Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string carNum = Console.ReadLine();

            var matrix = new char[n, n];
            FillTheMatrix(n, matrix);

            int kmCounter = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"Racing car {carNum} DNF.");
                    break;
                } 
                (int row, int col) = Position(matrix);
                //something went wrong
                if ((row, col) == (100, 100))
                {
                    break;
                }


                if (command == "up")
                {
                    kmCounter += Move(row, col, row - 1, col, matrix, carNum);
                }
                else if (command == "down")
                {
                    kmCounter += Move(row, col, row + 1, col, matrix, carNum);
                }
                else
                if (command == "right")
                {
                    kmCounter += Move(row, col, row, col + 1, matrix, carNum);

                }
                else if (command == "left")
                {
                    kmCounter += Move(row, col, row, col - 1, matrix, carNum);
                }

                bool isFinished = IsFinished(matrix);
                if(isFinished == true)
                {
                    break;
                }
            }

            Console.WriteLine($"Distance covered {kmCounter} km.");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write(String.Join("", matrix[row, col]));
                Console.WriteLine();
            }
        }

        static bool IsFinished(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'F')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void FillTheMatrix(int n, char[,] matrix)
        {            for (int r = 0; r < n; r++)
            {
                
                char[] line = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
            matrix[0, 0] = 'C';
        }
        static (int row, int col) Position(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'C')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //something went wrong
        }
        static int Move(int row, int col, int newRow, int newCol, char[,] matrix, string carNum)
        {
            int kmCounter = 10;
            matrix[row, col] = '.';
            char nextPosition = matrix[newRow, newCol];
            matrix[newRow, newCol] = 'C';

            if (nextPosition == 'T')
            {
                kmCounter = 30;
                matrix[newRow, newCol] = '.';
                (int tunnelTraveledRow, int tunnelTraveledCol) = Tunnel(matrix);
                matrix[tunnelTraveledRow, tunnelTraveledCol] = 'C';
            }

            if(nextPosition == 'F')
            {
                Console.WriteLine($"Racing car {carNum} finished the stage!");
            }

            return kmCounter;
        }
        static (int row, int col) Tunnel(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'T')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //something went wrong
        }
    }
}
