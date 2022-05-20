using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    internal class Program
    {
        class PetrolPump
        {
            public PetrolPump(int number, int amountOfPetrolForPump, int dictanceBetweenFromPetrolPumpToAnother)
            {
                this.Number = number;
                this.AmountOfPetrolForPump = amountOfPetrolForPump;
                this.DictanceBetweenFromPetrolPumpToNext = dictanceBetweenFromPetrolPumpToAnother;
            }
            public int Number { get; set; }
            public int AmountOfPetrolForPump { get; set; }
            public int DictanceBetweenFromPetrolPumpToNext { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPump> petrolPumpsQueue = new Queue<PetrolPump>();

            for (int i = 0; i <= n-1; i++)
            {
                int[] petrolPumpsInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int amountOfPetrolForPump = petrolPumpsInfo[0];
                int dictanceBetweenFromPetrolPumpToAnother = petrolPumpsInfo[1];

                PetrolPump petrolPump = new PetrolPump(i, amountOfPetrolForPump, dictanceBetweenFromPetrolPumpToAnother);
                petrolPumpsQueue.Enqueue(petrolPump);
            }
            int totalDistance = petrolPumpsQueue.Sum(petrolPump => petrolPump.DictanceBetweenFromPetrolPumpToNext);
            int truckDistance = 0;

            while (true)
            {
            int truckFuel = 0;
                foreach (var petrolPump in petrolPumpsQueue)
                {
                    truckFuel += petrolPump.AmountOfPetrolForPump;
                    if (truckFuel - petrolPump.DictanceBetweenFromPetrolPumpToNext > 0)
                    {

                    }
                    truckDistance += petrolPump.DictanceBetweenFromPetrolPumpToNext;
                }
               
            }
            Console.WriteLine();
        }
    }
}
