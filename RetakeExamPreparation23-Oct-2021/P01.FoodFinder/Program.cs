using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.FoodFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, char[]>()
            {
                { "pear", "pear".ToCharArray()},
                {"flour", "flour".ToCharArray() },
                {"pork","pork".ToCharArray() },
                { "olive",  "olive".ToCharArray()}
            };


            var firstLine = Console.ReadLine()
                 .Where(x => !Char.IsWhiteSpace(x))
                 .ToArray();

            var secondLine = Console.ReadLine()
                .Where(x => !Char.IsWhiteSpace(x))
                .ToArray();

            var vowels = new Queue<char>(firstLine);
            var consonants = new Stack<char>(secondLine);
            int counter = 0;
            while (true)
            {
                if (consonants.Count == 0)
                {
                    break;
                }
                char currentVowel = vowels.Dequeue();
                char currentConsonant = consonants.Pop();
                var newPear = words["pear"]
                   .Where(x => x != currentVowel)
                   .Where(x => x != currentConsonant)
                   .ToArray();
                words["pear"] = newPear;

                var newFlour = words["flour"]
                    .Where(x => x != currentVowel)
                    .Where(x => x != currentConsonant)
                    .ToArray();
                words["flour"] = newFlour;

                var newPork = words["pork"]
                   .Where(x => x != currentVowel)
                   .Where(x => x != currentConsonant)
                   .ToArray();
                words["pork"] = newPork;

                var newOlive = words["olive"]
                   .Where(x => x != currentVowel)
                   .Where(x => x != currentConsonant).ToArray();
                words["olive"] = newOlive;

                vowels.Enqueue(currentVowel);

            }

            foreach (var word in words)
            {
                if (word.Value.Length == 0)
                {
                    counter++;
                }

            }

            Console.WriteLine($"Words found: {counter}");
            foreach (var word in words)
            {
                if (word.Value.Length == 0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}
