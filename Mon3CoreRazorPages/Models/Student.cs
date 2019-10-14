using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mon3CoreRazorPages.Models
{
    public class Student
    {
        // Database Attributes
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties (relationships)
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
