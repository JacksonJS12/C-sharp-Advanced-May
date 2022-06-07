
using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ')
                .ToList();

            Action<string> printNames = name => Console.WriteLine("Sir " + name);
            names.ForEach(printNames);

            //Func<string, string> addPrefix = name => "Sir" + name;
            //foreach (var name in names)
            //{
            //    Console.WriteLine(addPrefix(name));
            //}

        }
    }
}
