using System;
using System.Collections.Generic;

namespace P06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
