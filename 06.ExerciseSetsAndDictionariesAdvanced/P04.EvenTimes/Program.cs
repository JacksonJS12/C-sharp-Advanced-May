using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenNumsAndTimes = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenNumsAndTimes.ContainsKey(number))
                {
                    evenNumsAndTimes.Add(number, 1);
                   
                }
                else
                {
                    evenNumsAndTimes[number]++;
                }
            }
            
            Console.WriteLine(evenNumsAndTimes
                .First(num => num.Value % 2 == 0)
                .Key); 
        }
    }
}
