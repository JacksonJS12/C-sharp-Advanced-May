namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            Dictionary<int, int> chooseCoins = ChooseCoins(coins, targetSum);

        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            
            return null;
        }
    }
}