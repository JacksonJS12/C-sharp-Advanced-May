using System;
using System.Linq;

namespace P02.Armory
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int initGold = 65;

            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            //fill the matrix
            FillTheMatrix(n, matrix);

            int goldForSwords = 0;

            try
            {
                while (true)
                {
                    string command = Console.ReadLine();
                    (int row, int col) = Position(matrix);
                    //break if officer leaves the armory
                    if ((row, col) == (100, 100))
                    {
                        break;
                    }


                    if (command == "up")
                    {
                        goldForSwords += Move(row, col, row - 1, col, matrix);
                    }
                    else if (command == "down")
                    {
                        goldForSwords += Move(row, col, row + 1, col, matrix);
                    }
                    else
                    if (command == "right")
                    {
                        goldForSwords += Move(row, col, row, col + 1, matrix);

                    }
                    else if (command == "left")
                    {
                        goldForSwords += Move(row, col, row, col - 1, matrix);
                    }
                    if (goldForSwords >= initGold)
                    {  //break if officer bays swords worth at least 65 gold
                        Console.WriteLine("Very nice swords, I will come back for more!");
                        break;
                    }
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine($"The king paid {goldForSwords} gold coins.");

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
                    if (matrix[r, c] == 'A')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //something went wrong
        }

        static int Move(int row, int col, int newRow, int newCol, char[,] matrix)
        {
            matrix[row, col] = '-';
            if (0 > newRow ||
                0 > newCol ||
                matrix.GetLength(0) < newRow ||
                matrix.GetLength(1) < newCol)
            {
                throw new ArgumentException("I do not need more swords!");
            }
            char gold = matrix[newRow, newCol];
            matrix[newRow, newCol] = 'A';


            if (char.IsDigit(gold))
            {
                return gold - '0';
            }
            else if (gold == 'M')
            {
                matrix[newRow, newCol] = '-';
                (int teleportedRow, int teleportedCol) = Teleport(matrix);
                matrix[teleportedRow, teleportedCol] = 'A';
            }

            return 0; 
        }

        static (int row, int col) Teleport(char[,] matrix)
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
