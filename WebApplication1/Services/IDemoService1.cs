using Bogus.DataSets;
using WebApplication1.Dto;

namespace WebApplication1.Services
{
    public interface IDemoService1
    {
        PersonDto AddPerson(PersonDto person);
        List<PersonDto> getAllPersons();
        PersonDto GetPerson(int id);
        List<PersonDto> getPersonsByGender(Name.Gender gender);
        PersonDto RemovePerson(int id);
    }
}