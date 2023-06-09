using WebApplication1.Dto;

namespace WebApplication1.Services
{
    public class AnotherService : IAnotherService
    {
        IDemoService _demoService;
        public AnotherService(IDemoService demoService)
        {
            _demoService = demoService;
        }

        public List<PersonDto> GetPersons()
        {
            return _demoService.getAllPersons();
        }

    }
}
