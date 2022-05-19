using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            List<int> ordersList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> ordersQueue = new Queue<int>(ordersList);
            Console.WriteLine(ordersQueue.Max());

            for (int order = 1; order <= ordersList.Count; order++)
            {
                if (quantityFood >= ordersQueue.Peek())
                {
                    quantityFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
            }
        }
    }
}
