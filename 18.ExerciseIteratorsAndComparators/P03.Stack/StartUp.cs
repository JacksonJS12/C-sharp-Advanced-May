using System;
using System.Linq;

namespace P03.Stack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0] == "END")
                {
                    break;
                }

               else if (tokens[0] == "Push")
                {
                    stack.Push(tokens
                        .Skip(1)
                        .Select
                        (e => e.Split(",")
                        .First())
                        .ToArray());
                }
                else if(tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        throw;
                    }
                }
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
