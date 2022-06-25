using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BeaversAtWork
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<char> woodsBranches = new List<char>();
        int woodsCounter = 0;

        var matrix = new char[n, n];
        for (int r = 0; r < n; r++)
        {
            char[] line = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();
            for (int c = 0; c < n; c++)
            {
                matrix[r, c] = line[c];
                if (char.IsLower(matrix[r, c]))
                {
                    woodsBranches.Add(matrix[r, c]);
                    woodsCounter++;
                }
            }
        }

        (int row, int col) beaverPosition = BeaverPosition(matrix);
        while (true)
        {
            
            string cmd = Console.ReadLine();
            if (cmd == "end")
            {
                break;
            }
            else if (cmd == "up")
            {
            }
            else if (cmd == "down")
            {

            }
            else if (cmd == "left")
            {

            }
            else if (cmd == "right")
            {

            }
        }
    }

     static void Move(int row, int col, int newRow, int newCol, char[,] matrix)
    {
        matrix[row, col] = '-';
        matrix(newRow, newCol) = 'B';
    }

    static (int row, int col) BeaverPosition(char[,] matrix)
    {
        int newRow = 0;
        int newCol = 0;
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if (matrix[r, c] == 'B')
                {
                    newRow = r;
                    newCol = c;
                }
            }
        }
        return (newRow, newCol);
    }
}
