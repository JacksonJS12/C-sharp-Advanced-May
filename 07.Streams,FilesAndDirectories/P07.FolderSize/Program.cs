namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"../../../Files/TestFolder";
            string outputPath = @"../../../Files/output.txt";




            double size = GetFolderSize(folderPath);
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(size);
            }
        }

        public static double GetFolderSize(string folderPath)
        {
            double size = 0;
            string[] files = Directory.GetFiles(folderPath);
            string[] subDirectories = Directory.GetDirectories(folderPath);

            foreach (string subDirectory in subDirectories)
            {
                size += GetFolderSize(subDirectory);
            }

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            return size / 1024;
        }
    }
}