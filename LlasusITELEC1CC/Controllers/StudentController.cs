using LlasusITELEC1CC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LlasusITELEC1CC.Controllers
{
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            Student st = new Student();

            st.StudentId = 1;
            st.StudentName = "Ralph Llasus";
            st.DateEnrolled = DateTime.Now;
            st.StudentCourse = Course.BSIT;
            st.Email = "ralphangelo.llasus.cics@ust.edu.ph";

            ViewBag.student = st;
            return View();
        }
    }
}
