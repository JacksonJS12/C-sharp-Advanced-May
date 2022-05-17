using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var reversed = expr.Reverse().ToArray();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < reversed.Length; i++)
            {
                stack.Push(reversed[i]);
            }
            for (int i = 0; i < reversed.Length; i++)
            {
                string plusOrMinus = string.Empty;
                if (expr[i] == "+" || expr[i] == "-")
                {
                     plusOrMinus = stack.Pop();
                }
                else
                {
                    int num = int.Parse(plusOrMinus + stack.Pop());
                }
            }
        }
    }
}
