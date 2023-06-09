using Bogus;
using WebApplication1.Dto;
using static Bogus.DataSets.Name;

namespace WebApplication1
{
    public static class DataMaker
    {
        public static List<PersonDto> getPersons()
        {
            var testPerson = new Faker<PersonDto>().RuleFor(u => u.Gender, f => f.PickRandom<Gender>())

    //Basic rules using built-in generators
    .RuleFor(u => u.Id, (f, u) => f.UniqueIndex)
    .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
    .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
    .RuleFor(u => u.Username, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
    .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))

    //Compound property with context, use the first/last name properties
    .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName);

            var personList = testPerson.Generate(10);
            return personList;
        }
    }
}
