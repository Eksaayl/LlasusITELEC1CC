using Microsoft.AspNetCore.Mvc;
using LlasusITELEC1CC.Models;
namespace LlasusITELEC1CC.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now, 
                InstructorEmail = "gabrielmontano@gmail.com", Rank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorName = "Leo Lintag", DateHired= DateTime.Now,
                InstructorEmail = "leolintag@gmail.com", Rank= Rank.AssistProf
            },
            new Instructor()
            {
                InstructorName = "Zxy Montano", DateHired = DateTime.Now,
                InstructorEmail = "Zxymontano@gmail.com", Rank = Rank.Prof
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }
    }
}
