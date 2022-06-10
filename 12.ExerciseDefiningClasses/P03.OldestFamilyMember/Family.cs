using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> people;
        public Family()
        {
            this.people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = this.people.Max(member => member.Age);
            return this.people.First(member => member.Age == maxAge);
        }
    }
}
