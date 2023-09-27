using System.ComponentModel.DataAnnotations;
namespace LlasusITELEC1CC.Models
{ 
    public enum Rank
    {   
    Instructor, AssistProf, AssociateProf, Prof
    }

    public enum IsTenured
    {
    Yes, No
    }
    public class Instructor
    {
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [Required(ErrorMessage = "Please enter your First Name")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Please enter your Last Name")]
    public string LastName { get; set; }
    public IsTenured IsTenured { get; set; }

    [Display(Name = "Academic Rank")]
    public Rank Rank { get; set; }

    [Display(Name = "Date Hired")]
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateHired { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Please enter your Email Address")]
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
    public string? Email { get; set; }

    [Phone]
    [Required(ErrorMessage = "Please provide a mobile number")]
    [RegularExpression("[0-9]{2} - [0-9]{3} - [0-9]{4}", ErrorMessage = "Follow the format 00-000-0000")]
    public string? Mobile { get; set; }
    }

}
