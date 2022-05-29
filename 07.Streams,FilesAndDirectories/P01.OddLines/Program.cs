
namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
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
                            if (lineNum % 2 == 1)
                            {
                                writer.WriteLine(line);
                                writer.Flush();
                            }
                            lineNum++;
                            line = reader.ReadLine();
                        }

                    }
                }
            }
        }
    }
}