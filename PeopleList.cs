using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBoss
{
    public class PeopleList
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
            new PeopleList()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new PeopleList()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new PeopleList()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new PeopleList()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new PeopleList()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new PeopleList()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new PeopleList()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            }
        };

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Guid GenderId { get; private set; }
    }
}

