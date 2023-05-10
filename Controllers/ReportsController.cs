using Microsoft.AspNetCore.Mvc;
using Reports.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reports.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private static readonly List<Report> reports = new List<Report>{ new Report("Изучение Virtual Box", "Установить Ubuntu в качестве гостевой ОС"), new Report("Работа с файловой системой", "Изучить основные команды терминала Linux, необходимые для работы с файловой системой"), new Report("Права доступа", "Установите разрешения для всех файлов в указанной выше структуре папок на чтение и запись для владельца и группы и никаких разрешений для всех остальных"), new Report("Перенаправление", "Изучить работу потоков stdin, stdout, stderr и их перенаправление.")};
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return reports.Select(e => e.Name);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Report Get(int id)
        {
            return reports[id];
        }
    }
}
