using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ').ToList();

            Func<string, bool> function = name => name.Length <= targetLength;

            names = names.Where(function).ToList();

            Action<List<string>> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            print(names);
        }
    }
}
