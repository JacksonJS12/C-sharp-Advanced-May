using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> getMinElement = numbers => numbers.Min();

            Console.WriteLine(getMinElement(numbers));
        }
    }
}
