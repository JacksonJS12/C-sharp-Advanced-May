using System;
using System.Linq;

namespace P01.RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = Sum(array, 0);
            Console.WriteLine(sum);
        }

         static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            int sum = array[index] + Sum(array, index + 1);
            return sum;
        }
    }
}
