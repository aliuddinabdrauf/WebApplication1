using WebApplication1.Dto;
using static Bogus.DataSets.Name;

namespace WebApplication1.Services
{
    public class DemoService : IDemoService
    {
        private readonly List<PersonDto> _persons;
        public DemoService()
        {
            _persons = DataMaker.getPersons();
        }

        public List<PersonDto> getAllPersons()
        {
            return _persons;
        }
        public List<PersonDto> getPersonsByGender(Gender gender)
        {
            return _persons.FindAll(o => o.Gender == gender);
        }
        public PersonDto GetPerson(int id)
        {
            return _persons.Find(o => o.Id == id);
        }

        public PersonDto AddPerson(PersonDto person)
        {
            _persons.Add(person);
            return person;
        }
        public PersonDto RemovePerson(int id)
        {
            var person = _persons.Find(o => o.Id == id);
            _persons.Remove(person);
            return person;
        }
    }
}
