using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<Student> Student { get; set; }

        public DbSet<Mon3CoreRazorPages.Models.Course> Course { get; set; }

        public DbSet<Mon3CoreRazorPages.Models.Enrollment> Enrollment { get; set; }
    }
}
