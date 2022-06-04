using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FilterByAge
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = PersonFilter(condition, ageThreshold);
            List<Person> matchingPeople =
                people.Where(filter).ToList();

            string format = Console.ReadLine();
            Action<Person> formatter = FormatPerson(format);
             PrintPeople(matchingPeople, formatter);
        }

        private static Action<Person> FormatPerson(string format)
        {
            if (format == "name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            if (format == "name")
            {
                return p => Console.WriteLine($"{p.Name}");
            }
            if(format == "age")
            {
                return p => Console.WriteLine($"{p.Age}");
            }
            throw new ArgumentException($"Invalid format: " + format);
        }

        private static void PrintPeople(List<Person> people, Action<Person> formatter)
        {
            foreach (var person in people)
            {
                formatter(person);
            }
        }

        private static Func<Person, bool> PersonFilter(
             string condition, int ageThreshold)
        {
            if (condition == "older")
            {
                return x => x.Age >= ageThreshold;
            }
            if (condition == "younger")
            {
                return x => x.Age < ageThreshold;
            }
            throw new ArgumentException($"Invalid filter: {condition} {ageThreshold}");
        }

        private static List<Person> ReadPeople()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                people.Add(new Person { Name = name, Age = age });
            }
            return people;
        }
    }
}
