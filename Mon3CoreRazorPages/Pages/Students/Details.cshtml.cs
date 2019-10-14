using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mon3CoreRazorPages.Models;

namespace Mon3CoreRazorPages.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Mon3CoreRazorPages.Models.UniversityContext _context;

        public DetailsModel(Mon3CoreRazorPages.Models.UniversityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
