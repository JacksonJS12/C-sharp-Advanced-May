using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class People
    {
        private List<Person> people = new List<Person>();
        public List<Person> OrderedList()
        {
            List<Person> modifiedListOfPeople = this.people.Where(member => member.Age > 30).ToList();
            modifiedListOfPeople = modifiedListOfPeople.OrderBy(x => x.Name).ToList();
            return modifiedListOfPeople;
        }
        public void AddMember(Person member)
        {
            people.Add(member);
        }
    }
}
