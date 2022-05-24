using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> countsByNum = new Dictionary<double, int>();
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var num in input)
            {
                if (countsByNum.ContainsKey(num))
                {
                    countsByNum[num]++;
                }
                else
                {
                    countsByNum[num] = 1;
                }
            }

            foreach (var count in countsByNum)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }

        }
    }
}
