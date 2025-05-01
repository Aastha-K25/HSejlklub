using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HSejlklub.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}

public class MedlemModel
{
    public string Medlemskab { get; set; } // F.eks. "Junior", "Senior"
    public string Navn { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }
    public DateTime Fødselsdato { get; set; }
    public string Køn { get; set; } // Mand, Kvinde, Ønsker ikke at oplyse
    public string Adresse1 { get; set; }
    public string Adresse2 { get; set; }
    public string By { get; set; }
    public string Postnummer { get; set; }
}