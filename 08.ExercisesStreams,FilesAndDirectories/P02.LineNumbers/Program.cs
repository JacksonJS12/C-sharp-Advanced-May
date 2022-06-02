namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            int linesCounter = 0;
            int lethersCounter = 0;
            int symbolsCounter = 0;

            List<string> outputLines = new List<string>();
            foreach (string line in lines)
            {
                linesCounter++;

                lethersCounter = line.Count(char.IsLetter);

                symbolsCounter = line.Count(char.IsPunctuation);

                string modifiedLine = $"Line {linesCounter}: {line} ({lethersCounter})({symbolsCounter})";

                outputLines.Add(modifiedLine);
            }
            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}