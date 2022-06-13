using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            People people = new People();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string member = Console.ReadLine();
                string name = member.Split()[0];
                int age = int.Parse(member.Split()[1]);

                Person person = new Person(name, age);
                people.AddMember(person);
            }
            List<Person> modifiedList = people.OrderedList();
           

            for (int i = 0; i < modifiedList.Count; i++)
            {
                Console.WriteLine(modifiedList[i].Name + " - " + modifiedList[i].Age);
            }
        }
    }
}
