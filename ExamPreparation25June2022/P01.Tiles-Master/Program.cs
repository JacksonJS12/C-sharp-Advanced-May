using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace P01.Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tilesForTheLocations = new Dictionary<string, int>() {
                {"Countertop", 60},
                {"Oven", 50},
                {"Sink", 40},
                {"Wall", 70}
            };

            var tilesForTheLocationsCounter = new Dictionary<string, int>() {
                {"Floor", 0},
                {"Countertop", 0},
                {"Oven", 0},
                {"Sink", 0},
                {"Wall", 0}
            };

            var whiteTiles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            var greyTiles = new Queue<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse));

            while (true)
            {
                int currWhiteTile = whiteTiles.Pop();
                int currGreyTile = greyTiles.Dequeue();

                if (currWhiteTile == currGreyTile)
                {
                    int tilesSum = currGreyTile + currWhiteTile;
                    bool flag = false;
                    foreach (var location in tilesForTheLocations)
                    {
                        if (location.Value == tilesSum)
                        {
                            foreach (var locationCounter in tilesForTheLocationsCounter)
                            {
                                if (locationCounter.Key == location.Key)
                                {
                                    tilesForTheLocationsCounter[locationCounter.Key] += 1;
                                    flag = true;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    if (!flag)
                    {
                        tilesForTheLocationsCounter["Floor"] += 1;
                    }
                    
                }
                else
                {
                    currWhiteTile /= 2;
                    whiteTiles.Push(currWhiteTile);

                    greyTiles.Enqueue(currGreyTile);
                }

                if (whiteTiles.Count <= 0 || greyTiles.Count <= 0)
                {
                    break;
                }
            }

            string whiteTilesRes = whiteTiles.Count > 0 ? $"White tiles left: {string.Join(", ", whiteTiles)}" : "White tiles left: none";
            Console.WriteLine(whiteTilesRes);

            string greyTilesRes = greyTiles.Count > 0 ? $"Grey tiles left: {string.Join(", ", greyTiles)}" : "Grey tiles left: none";
            Console.WriteLine(greyTilesRes);

            foreach (var location in tilesForTheLocationsCounter)
            {
                if (location.Value != 0)
                {
                    Console.WriteLine($"{location.Key}: {location.Value}");
                }
            }
        }
    }
}
