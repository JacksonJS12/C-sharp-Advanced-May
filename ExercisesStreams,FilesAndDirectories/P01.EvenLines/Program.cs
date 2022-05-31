namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"C:\Users\ricky\source\repos\C-sharp-Advanced-May\ExercisesStreams,FilesAndDirectories";

            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            int counter = 0;
            StreamReader reader;
            using (reader = new StreamReader(inputFilePath)) ;
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Replace(line);

                   line = Reverse(line);

                    if (counter % 2 ==0)
                    {

                    }

                    line = Console.ReadLine();
                    counter++;
                }
            }
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
