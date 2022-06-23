using System;
using System.Collections.Generic;

namespace P05.ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            var toekens = Console.ReadLine().Split();
            while (toekens[0] != "END")
            {
                string personName = toekens[0];
                int personAge = int.Parse(toekens[1]);
                string personTown = toekens[2];

                people.Add(new Person(personName, personAge, personTown));
                toekens = Console.ReadLine().Split();
            }

            var index = int.Parse(Console.ReadLine()) - 1;
            var equal = 0;
            var notEqual = 0;

            foreach (var person in people)
            {
                if (people[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }
            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}
