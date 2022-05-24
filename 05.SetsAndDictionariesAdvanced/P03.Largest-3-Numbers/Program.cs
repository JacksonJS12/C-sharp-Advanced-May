using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
               .ToList();

            Console.WriteLine(String.Join(" ", input));

        }
    }
}
