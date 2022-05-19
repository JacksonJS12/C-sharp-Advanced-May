using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int nToPush = numbers[0];
            int sToPop = numbers[1];
            int xToFind = numbers[2];

            List<int> numberList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < nToPush; i++)
            {
                queue.Enqueue(numberList[i]);
            }

            for (int i = 0; i < sToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (queue.Contains(xToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
