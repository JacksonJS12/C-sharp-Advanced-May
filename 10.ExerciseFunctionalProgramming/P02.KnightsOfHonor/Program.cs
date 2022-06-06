
using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(' ')
                .ToList();

            Action<string> printNames = names => Console.WriteLine("Sir " + names);
            list.ForEach(printNames);
        }
    }
}
