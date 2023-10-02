using ElevateProjectFinal.Models;

namespace ElevateProjectFinal.Services
{
    public class CourseService : ICourseService
    {
        private DatabaseContext databaseContext;
        public CourseService(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void Create(Course course)
        {
            databaseContext.Course.Add(course);
            databaseContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Course Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
