using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mon3CoreRazorPages.Pages
{
    public class HelloModel : PageModel
    {
        public String name;

        /// <summary>
        /// This method is called when the web page loads
        /// and sets the name to nothing
        /// </summary>
        public void OnGet()
        {
            name = null;
        }

        /// <summary>
        /// This method is called when the user clicks
        /// on the submit button and it retreives the
        /// name from the form and stores it in the
        /// Model properties
        /// </summary>
        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}