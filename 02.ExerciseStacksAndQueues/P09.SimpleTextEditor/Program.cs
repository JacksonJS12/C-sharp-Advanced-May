 using System;
using System.Collections.Generic;
using System.Text;

namespace P09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           StringBuilder text = new StringBuilder();

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string cmd = Console.ReadLine();
                // string cmdType = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                if (cmd.StartsWith("1"))
                {
                    stack.Push(text.ToString());
                    string textForAdd = cmd.Split()[1];
                    text.Append(textForAdd);
                }
                else if (cmd.StartsWith("2"))
                {
                    stack.Push(text.ToString());
                    int count = int.Parse(cmd.Split()[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (cmd.StartsWith("3"))
                {
                    int index = int.Parse(cmd.Split()[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (cmd.StartsWith("4"))
                {
                    text = new StringBuilder(stack.Pop());
                }
               
            }
        }
    }
}
