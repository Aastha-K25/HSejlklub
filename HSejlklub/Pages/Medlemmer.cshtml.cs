using Microsoft.AspNetCore.Mvc.RazorPages;
using HSejlklub.Models;
using HSejlklub.Models.Repositories;


namespace HSejlklub.Pages
{
    public class MedlemslisteModel : PageModel
    {
        public List<Medlem> Medlem{ get; set; }

        public void OnGet()
        {
            Medlem = MedlemRepository.HentAlle();
        }
    }
}
    