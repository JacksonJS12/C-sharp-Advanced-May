using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                var writer = new StreamWriter("ouput.txt");
                using (writer)
                {
                    while (true)
                    {
                        int lineNum = 0;
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            writer.WriteLine(lineNum + ". " + line);
                          
                            lineNum++;
                            line = reader.ReadLine();
                        }

                    }
                }
            }
        }
    }
}
