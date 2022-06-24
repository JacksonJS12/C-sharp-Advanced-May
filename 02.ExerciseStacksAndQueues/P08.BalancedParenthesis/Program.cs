using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesStack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (parenthesStack.Any())
                {
                    char check = parenthesStack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                }
                parenthesStack.Push(symbol);
            }
            Console.WriteLine(!parenthesStack.Any() ? "YES" : "NO");
        }
    }
}
