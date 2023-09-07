using LlasusITELEC1CC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LlasusITELEC1CC.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>()
       {
            new Student()
            {
            Id = 1, Name = "Gabriel Montano", Course = Course.BSIT, Admission = DateTime.Now,
                Email = "ghaby021@gmail.com", GPA = "1.5"
            },
            new Student()
            {
            Id = 2, Name = "Zyx Montano", Course = Course.BSIS, Admission = DateTime.Now,
                Email = "zyx@gmail.com", GPA = "1"
            },
            new Student()
            {
            Id = 3, Name = "Aerdriel Montano", Course = Course.BSCS, Admission = DateTime.Now,
                Email = "aerdriel@gmail.com", GPA = "1.5"
            }   
       };
        public IActionResult Index()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetail(int id)
        {

            Student? student = StudentList.FirstOrDefault(std => std.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult UpdateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }
    }
}
