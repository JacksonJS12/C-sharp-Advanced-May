using System;
using System.Linq;

namespace P02.Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];

            #region Fill The Matrix
            for (int r = 0; r < rows; r++)
            {
                char[] line = Console.ReadLine()
                    .ToCharArray();

                matrix[r] = line;
            }
            #endregion

            bool flag = false;
            int rotCounter = 0; 
            int holesCounter = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                
                if (cmd == "End")
                {
                    break;
                }

                //Vanko position
                int vankoCurrRow = 0;
                int vankoCurrCol = 0;

                #region Read Vanko's position
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < rows; c++)
                    {
                        if (matrix[r][c] == 'V')
                        {
                            vankoCurrRow = r;
                            vankoCurrCol = c;
                        }
                        else if (matrix[r][c] == 'E')
                        {
                            flag = true;
                        }
                    }
                }
                //if he gets electrocuted
                if (flag)
                {
                    break;
                }
                #endregion

                #region Move
                if (cmd == "up" && vankoCurrRow - 1 >= 0)
                {
                    if (matrix[vankoCurrRow - 1][vankoCurrCol] == 'R')
                    {
                        rotCounter++;
                    }
                    Move(vankoCurrRow, vankoCurrCol, vankoCurrRow - 1, vankoCurrCol, matrix);
                }
                else if (cmd == "down" && vankoCurrRow + 1 <= rows)
                {
                    if (matrix[vankoCurrRow + 1][vankoCurrCol] == 'R')
                    {
                        rotCounter++;
                    }
                    Move(vankoCurrRow, vankoCurrCol, vankoCurrRow + 1, vankoCurrCol, matrix);
                }
                else if (cmd == "left" && vankoCurrCol - 1 >= 0)
                {
                    if (matrix[vankoCurrRow][vankoCurrCol - 1] == 'R')
                    {
                        rotCounter++;
                    }
                    Move(vankoCurrRow, vankoCurrCol, vankoCurrRow, vankoCurrCol - 1, matrix);
                }
                else if (cmd == "right" && vankoCurrCol + 1 <= rows)
                {
                    if (matrix[vankoCurrRow][vankoCurrCol + 1] == 'R')
                    {
                        rotCounter++;
                    }
                    Move(vankoCurrRow, vankoCurrCol, vankoCurrRow, vankoCurrCol + 1, matrix);
                }
                #endregion
            }

            
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < rows; c++)
                {
                    if (matrix[r][c] == '*' || matrix[r][c] == 'E' || matrix[r][c] == 'V')
                    {
                        holesCounter++;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCounter} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesCounter} hole(s) and he hit only {rotCounter} rod(s).");
            }

            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("", line));
            }
        }
        public static void Move(int vankoCurrRow, int vankoCurrCol, int vankoNewRow, int vankoNewCol, char[][] matrix)
        {
            if (matrix[vankoNewRow][vankoNewCol] == 'R')
            {
                Console.WriteLine("Vanko hit a rod!");
                return;
            }
            else if (matrix[vankoNewRow][vankoNewCol] == 'C')
            {
                matrix[vankoNewRow][vankoNewCol] = 'E';
                matrix[vankoCurrRow][vankoCurrCol] = '*';
                return;
            }
            else if (matrix[vankoNewRow][vankoNewCol] == '*')
            {
                Console.WriteLine($"The wall is already destroyed at position [{vankoNewRow}, {vankoNewCol}]!");
            }
    
            matrix[vankoCurrRow][vankoCurrCol] = '*';
            matrix[vankoNewRow][vankoNewCol] = 'V';
        }
    }
}
