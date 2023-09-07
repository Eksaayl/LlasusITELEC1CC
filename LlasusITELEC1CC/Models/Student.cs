namespace LlasusITELEC1CC.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Admission { get; set;  }
        public Course Course { get; set;  }
        public string Email { get; set; }
        public string GPA { get; set; }
    }
}