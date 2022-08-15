using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P01.Blacksmith
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>();
            Stack<int> carbon = new Stack<int>();

            var swords = new Dictionary<string, int>()
            {
                { "Gladius", 70 },
                { "Shamshir", 80 },
                {"Katana", 90 },
                {"Sabre", 110 },
                {"Broadsword", 150 }

            };
            var steelList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            foreach (var st in steelList)
            {
                steel.Enqueue(st);
            }

            var carbonList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            foreach (var carb in carbonList)
            {
                carbon.Push(carb);
            }

            int swordsCounter = 0;
            var forgedSwords = new SortedDictionary<string, int>()
            {
                { "Gladius", 0},
                { "Shamshir", 0 },
                {"Katana", 0 },
                {"Sabre", 0 },
                {"Broadsword", 0 }
            };
            while (true)
            {
                if (steel.Count <= 0 ||
                   carbon.Count <= 0)
                {
                    break;
                }
                int firstSteel = steel.Dequeue();
                int lastCarbon = carbon.Pop();
                int totalSum = firstSteel + lastCarbon;

                if (swords.Any(s => s.Value == totalSum))
                {
                    string swordName = swords.FirstOrDefault(s => s.Value == totalSum).Key;

                    swordsCounter++;
                    forgedSwords[swordName]++;
                }
                else
                {
                    lastCarbon += 5;
                    carbon.Push(lastCarbon);
                }


            }

            if (swordsCounter == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword."); ;
            }
            else
            {
                Console.WriteLine($"You have forged {swordsCounter} swords.");
            }


            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {String.Join(", ", steel)}");

            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");

            }
            else
            {
                Console.WriteLine($"Carbon left: {String.Join(", ", carbon)}");
            }

            foreach (var sword in forgedSwords.OrderBy(s => s.Key))
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }
        }
    }
}
