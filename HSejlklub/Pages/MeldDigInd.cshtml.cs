using HSejlklub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HSejlklub.Pages;

    public class PrivacyModel : PageModel
    {
        [BindProperty] public MeldDigInd MeldDigInd  { get; set; }

        public void OnGet()
        {
        }
    }