namespace ElevateProjectFinal.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
    }
}
