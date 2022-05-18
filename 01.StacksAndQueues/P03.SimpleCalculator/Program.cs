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
                int sum = 0;
                string plusOrMinus = string.Empty;
                if (expr[i] == "+" || expr[i] == "-")
                {
                    plusOrMinus = stack.Pop();
                }
                else
                {
                    int lastNum = 0;
                    if (!(plusOrMinus == string.Empty))
                    {
                        sum = lastNum + int.Parse(stack.Pop());
                         lastNum = int.Parse(plusOrMinus + stack.Pop());
                    }
                    else
                    {
                         lastNum = int.Parse(stack.Pop());
                    }
                  
                }
            }
        }
    }
}
