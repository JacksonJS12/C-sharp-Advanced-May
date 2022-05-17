using System;
using System.Collections;
using System.Collections.Generic;

namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                char ch = expr[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subexpr = expr.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subexpr);
                }
            }

        }
    }
}
