using System;
using System.Linq;

namespace P06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            while (true)
            {
                string[] cmd = Console.ReadLine()
                    .Split(' ');
                if (cmd[0] == "END")
                {
                    break;
                }
                if (cmd[0] == "Add" || cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);
                    if (cmd[0] == "Subtract")
                    {
                       value = -value;
                    }
                    if (row >= 0 && 
                        row < jaggedArray.Length && 
                        col >= 0 &&
                        col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
              
            }
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
