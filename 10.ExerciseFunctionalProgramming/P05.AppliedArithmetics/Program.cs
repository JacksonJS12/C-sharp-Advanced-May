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

            Func<List<int>, List<int>> function = null;
            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    function = list => list.Select(number => number += 1).ToList();
                    numbers = function(numbers);
                }
                else if (command == "multiply")
                {
                    function = list => list.Select(number => number *= 2).ToList();
                    numbers = function(numbers);
                }
                else if (command == "subtract")
                {
                    function = list => list.Select(number => number -= 1).ToList();
                    numbers = function(numbers);
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
