using Microsoft.EntityFrameworkCore;

namespace ElevateProjectFinal.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }
        public DbSet<User> User => Set<User>();
        public DbSet<Assignment> Assignment => Set<Assignment>();
        public DbSet<Enrollment> Enrollment => Set<Enrollment>();
        public DbSet<Course> Course => Set<Course>();

    }

}

