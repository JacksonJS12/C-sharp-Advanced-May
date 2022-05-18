using System;
using System.Collections.Generic;

namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            int totalCarPassed = 0;
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                           var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalCarPassed++;
                        }
                    }
                }
                else if (cmd == "end")
                {
                    Console.WriteLine($"{totalCarPassed} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }
        }
    }
}
