namespace LlasusITELEC1CC.Models
{ public enum Rank
    {
        Instructor, AssistProf, AssociateProf, Prof
    }
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsTenured { get; set;}
        public Rank Rank { get; set; }
        public DateTime DateHired { get; set;}
    }

    }


