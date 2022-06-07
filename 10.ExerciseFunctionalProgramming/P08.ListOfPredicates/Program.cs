using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> deviders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>();
            for (int number = 1; number <= n; number++)
            {
                numbers.Add(number);
            }

            List<int> divisibleNumbers = new List<int>();
            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var devider in deviders)
                {
                    Predicate<int> divisible = num => num % devider == 0;
                    if (divisible(number) == false)
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    divisibleNumbers.Add(number);
                }
            }
            Console.WriteLine(String.Join(" ", divisibleNumbers));
        }
    }
}
