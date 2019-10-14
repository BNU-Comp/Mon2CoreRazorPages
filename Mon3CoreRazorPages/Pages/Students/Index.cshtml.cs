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
    public class IndexModel : PageModel
    {
        private readonly UniversityContext _context;

        public IndexModel(UniversityContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
