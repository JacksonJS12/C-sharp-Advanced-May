
using System;
using System.Linq;

namespace P02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseStringToInt = x => int.Parse(x);
            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, int> indentity = n => n;

            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            int[] nums = tokens.Select(parseStringToInt).ToArray();
            int[] evenNums = nums.Where(isEven).ToArray();
            int[] orderedEvenNums = evenNums.OrderBy(indentity).ToArray();

            Console.WriteLine(string.Join(", ", orderedEvenNums));
        }
    }
}
