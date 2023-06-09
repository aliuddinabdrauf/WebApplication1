using WebApplication1.Dto;
using static Bogus.DataSets.Name;

namespace WebApplication1.Services
{
    public interface IDemoService
    {
        PersonDto AddPerson(PersonDto person);
        List<PersonDto> getAllPersons();
        PersonDto GetPerson(int id);
        List<PersonDto> getPersonsByGender(Gender gender);
        PersonDto RemovePerson(int id);
    }
}