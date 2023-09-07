namespace LlasusITELEC1CC.Models
{ public enum Rank
    {
        Instructor, AssistProf, AssociateProf, Prof
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorEmail { get; set;}
        public DateTime DateHired { get; set;}

        public Rank Rank { get; set;}
    }

    }


