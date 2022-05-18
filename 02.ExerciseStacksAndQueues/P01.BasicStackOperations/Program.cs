using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
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
                stack.Push(numberList[i]);
            }

            for (int i = 0; i < sToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(xToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
