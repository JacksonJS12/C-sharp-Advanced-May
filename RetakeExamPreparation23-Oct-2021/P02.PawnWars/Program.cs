using System;
using System.Linq;

namespace P02.PawnWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int matrixSize = 8;
            var matrix = new char[matrixSize, matrixSize];
            FillTheMatrix(matrixSize, matrix);

            char whitePawn = 'w';
            char blackPawn = 'b';

            while (true)
            {
                (int rowW, int colW) = PositionW(matrix);
                (int rowB, int colB) = PositionB(matrix);

                if (rowW - 1 == blackPawn)
                {
                    CaptureOpponentsPawn(rowW, colW, rowB, colB, matrix);
                }
                else if (rowW == 0)//the end of the board
                {
                    Console.WriteLine($"Game over! {whitePawn} pawn is promoted to a queen at ");//{coordinates}."
                }
                else if (rowB == matrixSize)//the end of the board
                {
                    Console.WriteLine($"Game over! {blackPawn} pawn is promoted to a queen at ");//{coordinates}."
                }

                Move(rowW, colW, matrix, whitePawn);
                Move(rowB, colB, matrix, blackPawn);


            }
        }

        static void CaptureOpponentsPawn(int rowW, int colW, int rowB, int colB, char[,] matrix)
        {

        }
        static void Move(int row, int col, char[,] matrix, char pawn)
        {
            matrix[row, col] = '-';
            int newRow = 0;
            if (pawn == 'w')
            {
                newRow = row - 1;
            }
            else if (pawn == 'b')
            {
                newRow = row + 1;
            }

            if (newRow >= 8)
            {
                throw new ArgumentException(); //became a queen
            }
            matrix[newRow, col] = pawn;

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
        static (int row, int col) PositionW(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'w')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //impossible case
        }
        static (int row, int col) PositionB(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLongLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLongLength(1); c++)
                {
                    if (matrix[r, c] == 'b')
                    {
                        return (r, c);
                    }
                }
            }
            return (100, 100); //impossible case
        }
    }
}
