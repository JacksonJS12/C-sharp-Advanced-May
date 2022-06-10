using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();

            Person person1 = new Person(20);

            Person person2 = new Person("Peter", 20);

        }
    }
}
