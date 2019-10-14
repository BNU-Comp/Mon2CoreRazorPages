using Microsoft.EntityFrameworkCore;
using Mon3CoreRazorPages.Models;

namespace Mon3CoreRazorPages.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
