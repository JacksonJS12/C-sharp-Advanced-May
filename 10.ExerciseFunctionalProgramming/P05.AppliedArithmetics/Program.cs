using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToList();

            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();
            Func<List<int>, List<int>> multipoly = list => list.Select(number => number *= 2).ToList();
            Func<List<int>, List<int> > subtract = list => list.Select(number => number -= 1).ToList();
            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multipoly(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
