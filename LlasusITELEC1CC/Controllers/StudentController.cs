using LlasusITELEC1CC.Models;
using LlasusITELEC1CC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LlasusITELEC1CC.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbData;

        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;

        }

        /* List<Student> StudentList = new List<Student>()
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
        }; */
        public IActionResult Index()
        {

            return View(_dbData.Students);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {

            if (!ModelState.IsValid)
                return View();

            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {

            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();


        }

        [HttpPost]


        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == studentChanges.Id);
            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;
                _dbData.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {

            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was a student found?
                return View(student);

            return NotFound();


        }
        [HttpPost]
        public IActionResult DeleteStudent(Student newStudent)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == newStudent.Id);
            if (student != null)
            {
                _dbData.Students.Remove(student);
                _dbData.SaveChanges();

            }
            return RedirectToAction("Index");
        }

    }
}
