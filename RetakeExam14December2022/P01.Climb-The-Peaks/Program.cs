    using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Climb_The_Peaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dailyPortions = new Stack<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse));

            var dailyStamina = new Queue<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse));

            var mountainsAndDifficulty = new Dictionary<string, int>() {
                {"Vihren", 80 },
                {"Kutelo", 90},
                {"Banski Suhodol", 100},
                {"Polezhan", 60},
                {"Kamenitza", 70}
            };

            var conqueredPeaks = new Dictionary<string, bool>() {
                {"Vihren", false },
                {"Kutelo", false},
                {"Banski Suhodol", false},
                {"Polezhan", false},
                {"Kamenitza", false}
            };

            int conqueredPeaksCounter = 0;
            int days = 7;
            for(int i = 0; i < 5; i++)
            {
                if (dailyPortions.Count == 0 ||
                    dailyStamina.Count == 0 ||
                    days <= 0)
                {
                    break;
                }


                int currDailyPortion = dailyPortions.Pop();
                int currDailyStamina = dailyStamina.Dequeue();

                int sum = currDailyPortion + currDailyStamina;

                if (sum >= mountainsAndDifficulty.ElementAt(i).Value)
                {
                    conqueredPeaks[mountainsAndDifficulty.ElementAt(i).Key] = true;
                    conqueredPeaksCounter++;
                    continue;
                }
                days--;
                i--;
            }

            var res = conqueredPeaksCounter == 5 ?
                "Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK" :
                "Alex failed! He has to organize his journey better next time -> @PIRINWINS";
            Console.WriteLine(res);

            if (conqueredPeaksCounter > 0) 
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var peek in conqueredPeaks)
                {
                    if (peek.Value == true)
                    {
                        Console.WriteLine(peek.Key);
                    }
                } 
            }
        }
    }
}
