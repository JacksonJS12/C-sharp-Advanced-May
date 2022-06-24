using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfARack = int.Parse(Console.ReadLine());

            Stack<int> prices = new Stack<int>(priceOfClothes);

            int sumOfClothes = 0;
            int numOfRacks = 1;

            //5 4 8 6 3 8 7 7 9 --- orders
            //16 -- capacity

            for (int i = priceOfClothes.Length - 1; i >= 0; i--)
            {
                sumOfClothes += priceOfClothes[i];

                if (sumOfClothes <= capacityOfARack)
                {
                    if (prices.Any())
                    {
                        prices.Pop();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    numOfRacks++;
                    sumOfClothes = 0;
                }
            }

            Console.WriteLine(numOfRacks);
        }
    }
}
