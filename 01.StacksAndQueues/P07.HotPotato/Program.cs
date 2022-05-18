using System;
using System.Collections;
using System.Collections.Generic;

namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(players);
            while (queue.Count > 1)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    var player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                var lostPLayer = queue.Dequeue();
                    Console.WriteLine($"Removed {lostPLayer}");
            }
            var lastPLayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPLayer}");
        }
    }
}
