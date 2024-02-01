using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _persons = new();
        public DemoDataAccess()
        {
            _persons.Add(new PersonModel() { Id = 1, FirstName = "Tom", LastName = "King" });
            _persons.Add(new PersonModel() { Id = 2, FirstName = "Tim", LastName = "Player" });

        }
        public List<PersonModel> GetPeople()
        {

            return _persons;
        }

        public PersonModel AddPerson(string firstName, string lastName)
        {
            PersonModel person = new() { FirstName = firstName, LastName = lastName };
            person.Id = _persons.Max(x => x.Id) + 1;
            _persons.Add(person);
            return person;


        }
    }
}
