using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            Stack<int> plates = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> orcs = new Stack<int>();
            for (int i = 1; i <= numberOfWaves; i++)
            {
                var currWave = Console.ReadLine()
                    .Split()
                    .Select(int.Parse);

                foreach (var orc in currWave)
                {
                    orcs.Push(orc);
                }

                if (i % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());
                    var platesAsList = plates.ToList();
                    platesAsList.Add(plate);
                    platesAsList.Reverse();
                    plates = new Stack<int>(platesAsList);
                }

                while (plates.Count > 0 && orcs.Count > 0)
                {
                    int currPlate = plates.Pop();
                    int currOrc = orcs.Pop();

                    if (currPlate > currOrc)
                    {
                        currPlate -= currOrc;
                        plates.Push(currPlate);
                    }
                    else if (currPlate < currOrc)
                    {
                        currOrc -= currPlate;
                        orcs.Push(currOrc);
                    }
                }

                if (plates.Count <= 0)
                {
                    break;
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
