namespace ElevateProjectFinal.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Course Course { get; set; }
        public string EnrollmentDate { set; get; }

    }
}
