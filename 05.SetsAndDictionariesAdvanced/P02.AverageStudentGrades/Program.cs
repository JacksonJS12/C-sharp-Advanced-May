using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<decimal>>();
            int gradesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < gradesCount; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string name = line[0];
                decimal grade = decimal.Parse(line[1]);
                if (!studentGrades.ContainsKey(name))
                    studentGrades.Add(name, new List<decimal>());

                studentGrades[name].Add(grade);
            }

            foreach (var name in studentGrades.Keys)
            {
                List<decimal> gardes = studentGrades[name];
                string grades = string.Join(" ", gardes.Select(g => g.ToString("f2")));
                decimal avg = Math.Round(studentGrades[name].Average(), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{name} -> {grades} (avg: {avg:f2})");
            }
        }
    }
}
