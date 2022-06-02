﻿namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath)); 
        }
        public static string ProcessLines(string inputFilePath)
        {
            int counter = -1;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
            return string.Empty;
        }
        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line)
        {
            return line.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@");
        }
    }
}
