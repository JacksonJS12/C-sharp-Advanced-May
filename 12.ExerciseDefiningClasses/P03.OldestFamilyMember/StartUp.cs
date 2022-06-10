using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string member = Console.ReadLine();
                string name = member.Split()[0];
                int age = int.Parse(member.Split()[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
