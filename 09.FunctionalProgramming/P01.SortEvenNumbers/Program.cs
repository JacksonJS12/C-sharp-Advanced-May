using System;
using System.Linq;

namespace P01.SortEvenNumbers
{
    internal class Program
    {
        static int Parse(string str) => int.Parse(str);
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(", ")
                .Select(Parse)
                .ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
