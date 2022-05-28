using System;
using System.Collections.Generic;

namespace P05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> times = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!times.ContainsKey(input[i]))
                {
                    times.Add(input[i], 1);
                }
                else
                {
                    times[input[i]]++;
                }
                
            }

            foreach (var time in times.Keys)
            {
                Console.WriteLine($"{time}: {times[time]} time/s");
            }
        }
    }
}
