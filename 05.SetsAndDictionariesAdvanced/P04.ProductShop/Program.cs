using System;
using System.Collections.Generic;

namespace P04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Revision")
                {
                    PrintPrces(prices);
                    break;
                }
                string[] tokens = line.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                AddProduct(prices, shop, product, price);
            }
        }

        private static void AddProduct(SortedDictionary<string, Dictionary<string, double>> prices, string shop, string product, double price)
        {
            if (!prices.ContainsKey(shop))
                prices.Add(shop, new Dictionary<string, double>());
            prices[shop][product] = price;
        }

        static void PrintPrces(SortedDictionary<string, Dictionary<string, double>> prices)
        {
            foreach (var shopeAndProducts in prices)
            {
                string shopName = shopeAndProducts.Key;
                Console.WriteLine(shopName + "->");
                var products = shopeAndProducts.Value;
                foreach (var productAndPrice in products)
                {

                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value} ");
                }
            }
        }
    }
}
