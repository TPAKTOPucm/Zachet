using Microsoft.AspNetCore.Mvc;
using Reports.Models;

namespace Reports.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeachersController : ControllerBase
    {
        private static readonly Teacher[] teachers = new[]
        {
        new Teacher("Бойков", "Павел", "Александрович"), new Teacher("Кремнев", "Александр", "Юрьевич"), new Teacher("Заманов", "Евгений", "Альбертович"), new Teacher("Разживайкин", "Игорь", "Станиславович"),new Teacher("Дутова", "Елена", "Алексеевна"),new Teacher("Козлов", "Артём", "Андреевич"),new Teacher("Городников", "Александр", "Игоревич"),new Teacher("Фабрикантова", "Елена", "Фёдоровна"),new Teacher("Быкова", "Екатерина", "Александровна")
    };

        public IEnumerable<string> Get()
        {
            return teachers.Select(t => $"{t.LastName} {t.FirstName[0]}. {t.MiddleName[0]}.");
        }
        [HttpGet("{id}")]
        public Teacher Get(int id)
        {
            return teachers[id];
        }
    }
}