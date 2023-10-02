namespace ElevateProjectFinal.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        //this is pointing to Candidate Tb
        public int UserId { get; set; }
        public string EnrollmentCount { get; set; }


        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
