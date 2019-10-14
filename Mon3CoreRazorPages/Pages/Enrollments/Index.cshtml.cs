using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mon3CoreRazorPages.Models;

namespace Mon3CoreRazorPages.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly Mon3CoreRazorPages.Models.UniversityContext _context;

        public IndexModel(Mon3CoreRazorPages.Models.UniversityContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; }

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollment
                .Include(e => e.Course)
                .Include(e => e.Student).ToListAsync();
        }
    }
}
