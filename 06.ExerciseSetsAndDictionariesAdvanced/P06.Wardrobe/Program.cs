using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string clothParams = Console.ReadLine();
                string color = clothParams.Split(" -> ")[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothes = wardrobe[color];
                string[] inputClothes = clothParams.Split(" -> ")[1]
                    .Split(",");
                foreach (string cloth in inputClothes)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }

            string searchedItem = Console.ReadLine();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                Dictionary<string, int> clothes = wardrobe[color.Key];
                foreach (var item in clothes)
                {
                    string searchedColor = searchedItem.Split(' ')[0];
                    string searchedCloth = searchedItem.Split(' ')[1];
                    if (searchedColor == color.Key &&
                        searchedCloth == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
