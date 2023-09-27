using System.ComponentModel.DataAnnotations;
namespace LlasusITELEC1CC.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }

    public class Student

    {

        [Display(Name = "Student ID")]

        public int StudentId { get; set; }



        public DateTime DateEnrolled { get; set; }
        [Display(Name = "Student ID")]

        public Course StudentCourse { get; set; }

        [Display(Name = "Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }


        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "GPA")]
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required(ErrorMessage = "Please enter your GPA")]
        public double GPA { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }



    }
}
