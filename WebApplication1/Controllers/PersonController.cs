using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto;
using WebApplication1.Services;
using static Bogus.DataSets.Name;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IDemoService _demoService;
       private IAnotherService _anotherService;
        public PersonController(IDemoService demoService, IAnotherService anotherService)
        {
            _demoService = demoService;
           _anotherService = anotherService;
        }
        [HttpGet]
        public List<PersonDto> GetAll()
        {
            return _demoService.getAllPersons();
        }
        [HttpDelete]
        public PersonDto Delete(int id) {
           return _demoService.RemovePerson(id);
        }
        [HttpGet]
        public PersonDto GetById(int id)
        {
            return _demoService.GetPerson(id);
        }
        [HttpGet]
        public List<PersonDto> GetByGender(Gender gender)
        {
            return _demoService.getPersonsByGender(gender);
        }
        [HttpPost]
        public PersonDto AddPerson([FromBody]PersonDto personDto)
        {
            return _demoService.AddPerson(personDto);
        }
        [HttpGet]
        public List<PersonDto> GetAllSame()
        {
            var list = _demoService.getAllPersons();
           list.AddRange(_anotherService.GetPersons());
            return list;
        }
    }
}
