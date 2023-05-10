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
        new Teacher("������", "�����", "�������������"), new Teacher("�������", "���������", "�������"), new Teacher("�������", "�������", "�����������"), new Teacher("�����������", "�����", "�������������"),new Teacher("������", "�����", "����������"),new Teacher("������", "����", "���������"),new Teacher("����������", "���������", "��������"),new Teacher("������������", "�����", "Ը�������"),new Teacher("������", "���������", "�������������")
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