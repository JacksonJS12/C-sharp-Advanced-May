using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> table = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var element in elements)
                {
                    table.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", table));
        }
    }
}
