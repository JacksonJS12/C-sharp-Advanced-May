
using System;
using System.Linq;

namespace P03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filter =
                (string x) => x.Length > 0 && char.IsUpper(x[0]);

            Console.WriteLine(
                string.Join(
                   "\r\n",
                (Console.ReadLine()
                .Split(" ")
                .Where(x => filter(x))
                .ToArray())
                ));
        }
    }
}
