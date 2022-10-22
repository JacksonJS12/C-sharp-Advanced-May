using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxCaffeinе = 300;
            int totalCaffeinе = 0;

            var milligramsOfCaffeinе = new Stack<int>();
            var energyDrinks = new Queue<int>();

            var milligramsOfCaffeinеInput = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            foreach (var item in milligramsOfCaffeinеInput)
            {
                milligramsOfCaffeinе.Push(item);
            }

            var energyDrinksInput = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            foreach (var item in energyDrinksInput)
            {
                energyDrinks.Enqueue(item);
            }

            while (true)
            {
                if (milligramsOfCaffeinе.Count == 0 ||
                    energyDrinks.Count == 0)
                {
                    break;
                }
                int currMilligramsOfCaffeinе = milligramsOfCaffeinе.Pop();
                int currenergyDrink = energyDrinks.Dequeue();

                int caffeinеSum = currMilligramsOfCaffeinе * currenergyDrink;
                if (caffeinеSum >= MaxCaffeinе - totalCaffeinе)
                {
                    totalCaffeinе -= 30;
                    energyDrinks.Enqueue(currenergyDrink);
                    continue;
                }

                totalCaffeinе += caffeinеSum;
            }

            if (energyDrinks.Count > 0)
            {
                Console.WriteLine($"Drinks left: {String.Join(", ", energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {totalCaffeinе} mg caffeine.");
        }
    }
}
