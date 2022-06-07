using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            List<int> numbers = new List<int>();
            for (int i = input[0]; i <= input[1]; i++) //input[0] -> startNumber       input[1] -> endNumber
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();
            Predicate<int> isEvenOrOdd = null;
            foreach (var number in numbers)
            {
               
                if (command == "odd")
                {
                    isEvenOrOdd = number => number % 2 != 0;
                }
                else if (command == "even")
                {
                    isEvenOrOdd = number => number % 2 == 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers.FindAll(isEvenOrOdd)));
        }
    }
}
