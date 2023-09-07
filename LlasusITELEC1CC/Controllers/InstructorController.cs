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
               Id = 1, FirstName = "Gabriel", LastName = "Montano", IsTenured = "Yes",
                DateHired = DateTime.Now, Rank = Rank.Instructor
            },
            new Instructor()
            {
               Id = 2, FirstName = "Leo", LastName = "Lintag", IsTenured = "Yes", 
                DateHired= DateTime.Now, Rank= Rank.AssistProf
            },
            new Instructor()
            {
               Id = 3, FirstName = "Zxy", LastName = "Uvw", IsTenured = "No", 
                DateHired = DateTime.Now, Rank = Rank.AssociateProf
            },
            new Instructor()
            {
               Id = 4, FirstName = "Qwer", LastName = "Tyui", IsTenured = "No",
                DateHired = DateTime.Now, Rank = Rank.Prof
            }
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            
            Instructor? instructor = InstructorList.FirstOrDefault(inst => inst.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
    }
}
