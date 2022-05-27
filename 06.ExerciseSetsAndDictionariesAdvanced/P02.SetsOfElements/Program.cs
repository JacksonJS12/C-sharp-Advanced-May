using System;
using System.Collections.Generic;

namespace P02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            int firstSetLength = int.Parse(input.Split(' ')[0]);
            int secondSetLength = int.Parse(input.Split(' ')[1]);

            HashSet<int> firstSet = new HashSet<int>();
            for (int i = 0; i < firstSetLength; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < secondSetLength; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
            
        }
    }
}
