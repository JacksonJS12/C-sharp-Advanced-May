using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BaristaContest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> quantitiesOfTheCoffee = new Queue<int>();
            Stack<int> quantitiesOfTheMilk = new Stack<int>();

            var drinks = new Dictionary<string, int>()
            {
                { "Cortado", 50 },
                { "Espresso", 75 },
                {"Capuccino", 100},
                {"Americano", 150 },
                {"Latte", 200 }

            };
            var firstLine = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();
            foreach (var coffee in firstLine)
            {
                quantitiesOfTheCoffee.Enqueue(coffee);
            }

            var secondLine = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToList();
            foreach (var milk in secondLine)
            {
                quantitiesOfTheMilk.Push(milk);
            }

            int counter = 0;
            var madedCoffees = new Dictionary<string, int>()
            {
                { "Cortado", 0 },
                { "Espresso", 0},
                {"Capuccino", 0},
                {"Americano", 0 },
                {"Latte", 0 }
            };
            while (true)
            {
                if (quantitiesOfTheCoffee.Count <= 0 ||
                   quantitiesOfTheMilk.Count <= 0)
                {
                    break;
                }
                int firstCoffee = quantitiesOfTheCoffee.Dequeue();
                int lastMilk = quantitiesOfTheMilk.Pop();
                int totalSum = firstCoffee + lastMilk;

                if (drinks.Any(s => s.Value == totalSum))
                {
                    string drink = drinks.FirstOrDefault(s => s.Value == totalSum).Key;

                    counter++;
                    madedCoffees[drink]++;
                }
                else
                {
                    lastMilk -= 5;
                    quantitiesOfTheMilk.Push(lastMilk);
                }


            }

            if (quantitiesOfTheCoffee.Count == 0 &&
                quantitiesOfTheMilk.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }



            if (quantitiesOfTheCoffee.Count == 0)
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.WriteLine($"Coffee left: {String.Join(", ", quantitiesOfTheCoffee)}");

            }

            if (quantitiesOfTheMilk.Count == 0)
            {
                Console.WriteLine("Milk left: none");

            }
            else
            {
                Console.WriteLine($"Milk left: {String.Join(", ", quantitiesOfTheMilk)}");
            }

            foreach (var coffee in madedCoffees.OrderBy(s => s.Value).ThenByDescending(k => k.Key))
            {
                if (coffee.Value > 0)
                {
                    Console.WriteLine($"{coffee.Key}: {coffee.Value}");
                }
            }
        }
    }
    
}
