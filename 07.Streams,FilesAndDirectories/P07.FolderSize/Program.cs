using System;
using System.IO;

namespace P07.FolderSize
{
    internal class FolderSizeCalculater
    {
        static void Main(string[] args)
        {
            decimal folderSize = CalcFolderSize("C:/Brother");
            Console.WriteLine(folderSize );
            Console.WriteLine("{0:f2} mb", folderSize / (1024 * 1024));
        }

        static decimal CalcFolderSize(string path)
        {
            decimal folderSize = 0;
            var dirInfo = new DirectoryInfo(path);
            
            foreach (var f in dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                folderSize += f.Length;
            }
            return folderSize;
        }
    }
}
