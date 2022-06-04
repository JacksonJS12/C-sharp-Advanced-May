using System;
using System.Linq;

namespace P04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x * 1.20m;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] nums = tokens.Select(decimal.Parse).ToArray();
            decimal[] numsWithVAT = nums.Select(addVAT).ToArray();

            Array.ForEach(numsWithVAT, x => Console.WriteLine($"{x:f2}"));
        }
    }
}
