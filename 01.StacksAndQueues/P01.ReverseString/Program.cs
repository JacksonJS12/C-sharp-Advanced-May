using System;
using System.Collections;
using System.Collections.Generic;

namespace P01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            foreach (var ch in str)
            {
                stack.Push(ch);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
