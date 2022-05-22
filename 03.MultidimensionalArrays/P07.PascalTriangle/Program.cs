using System;
using System.Numerics;

namespace P07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger[][] tringle = new BigInteger[n][];
            for (int row = 0; row < n; row++)
            {
                tringle[row] = new BigInteger[row + 1]; 
                tringle[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    tringle[row][col] =
                        tringle[row - 1][col - 1] + tringle[row - 1][col];
                }
                tringle[row][row] = 1;
            }

            foreach (var row in tringle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
