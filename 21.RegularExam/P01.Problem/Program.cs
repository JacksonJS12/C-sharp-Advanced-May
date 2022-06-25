using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Stack<int> areasOfTheWhiteTiles = new Stack<int>();

        int[] areasOfTheWhiteTilesInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        for (int i = 0; i < areasOfTheWhiteTilesInput.Length; i++)
        {
            areasOfTheWhiteTiles.Push(areasOfTheWhiteTilesInput[i]);
        }

        Queue<int> areasOfTheGreyTiles = new Queue<int>();

        int[] areasOfTheGreyTilesInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        for (int i = 0; i < areasOfTheGreyTilesInput.Length; i++)
        {
            areasOfTheGreyTiles.Enqueue(areasOfTheGreyTilesInput[i]);
        }

        //Location Tile area needed
        //Sink    40
        //Oven    50
        //Countertop  60
        //Wall    70
        var locationTileAreaNeeded = new Dictionary<string, int>
        {
            {"Sink", 40 },
            {"Oven", 50 },
            {"Countertop", 60 },
            {"Wall", 70},
            {"Floor", 0 }
        };
        var locationTilesCounter = new Dictionary<string, int>
        {
            {"Sink", 0 },
            {"Oven", 0 },
            {"Countertop", 0 },
            {"Wall", 0},
            {"Floor", 0 }
        };

        while (true)
        {
            if (areasOfTheGreyTiles.Count == 0 || areasOfTheWhiteTiles.Count == 0)
            {
                break;
            }
            int currWhiteTile = areasOfTheWhiteTiles.Peek();
            int currGreyTile = areasOfTheGreyTiles.Peek();
            if (currWhiteTile == currGreyTile)
            {
                int largerTile = currWhiteTile + currGreyTile;
                bool isThere = false;
                foreach (var areaNeeded in locationTileAreaNeeded)
                {
                    if (largerTile == areaNeeded.Value)
                    {
                        locationTilesCounter[areaNeeded.Key]++;
                        isThere = true;
                        break;
                    }
                }
                if (!isThere)
                {
                    locationTilesCounter["Floor"]++;
                }
                areasOfTheWhiteTiles.Pop();
                areasOfTheGreyTiles.Dequeue();
            }
            else
            {
                currWhiteTile /= 2;
                areasOfTheWhiteTiles.Pop();
                areasOfTheWhiteTiles.Push(currWhiteTile);

                areasOfTheGreyTiles.Dequeue();
                areasOfTheGreyTiles.Enqueue(currGreyTile);
            }
        }
        if (areasOfTheWhiteTiles.Count == 0)
        {
            Console.WriteLine("White tiles left: none");
        }
        else
        {
            Console.WriteLine($"White tiles left: {string.Join(", ", areasOfTheWhiteTiles)}");
        }

        if (areasOfTheGreyTiles.Count == 0)
        {
            Console.WriteLine("Grey tiles left: none");
        }
        else
        {
            Console.WriteLine($"Grey tiles left: {string.Join(", ", areasOfTheGreyTiles)}");
        }

        var locationTilesCounterOrdered = locationTilesCounter.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
        foreach (var kvp in locationTilesCounterOrdered)
        {
            if (kvp.Value != 0)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
