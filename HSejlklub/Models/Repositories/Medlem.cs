using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HSejlklub.Models.Repositories;
// Repository delen
public class Medlemmer : PageModel
{
    public List<Medlem> Medlem { get; set; }

    public void OnGet()
    {
        Medlem = new List<Medlem>
        {
            new Medlem { Fornavn = "Emma", Efternavn = "Hansen", Email = "emma.hansen@mail.dk", ErAktiv = true },
            new Medlem { Fornavn = "Lucas", Efternavn = "Møller", Email = "lucas.m@outlook.com", ErAktiv = false },
            new Medlem { Fornavn = "Freja", Efternavn = "Andersen", Email = "freja_a@gmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "William", Efternavn = "Jensen", Email = "williamj@hotmail.com", ErAktiv = true
            },
            new Medlem { Fornavn = "Ida", Efternavn = "Larsen", Email = "ida.l@live.dk", ErAktiv = false },
            new Medlem { Fornavn = "Mads", Efternavn = "Dalberg", Email = "madsdalb@hotmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "Sophie", Efternavn = "Pedersen", Email = "sophie2004@hotmail.com", ErAktiv = false
            },
            new Medlem { Fornavn = "Jonas", Efternavn = "Nielsen", Email = "jonas@hotmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "Oliver", Efternavn = "Sørensen", Email = "oliversørnsen@gmail.com", ErAktiv = true
            },
            new Medlem
            {
                Fornavn = "Laura", Efternavn = "Hansen", Email = "Laurahannsen@outlook.dk", ErAktiv = true
            },
            new Medlem { Fornavn = "Emil", Efternavn = "Rasmussen", Email = "emil003@hotmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "Clara", Efternavn = "holm", Email = "claraholm2003@hotmail.com", ErAktiv = true
            },
            new Medlem
            {
                Fornavn = "Victor", Efternavn = "Østergaard", Email = "voestergaard@gmail.com", ErAktiv = false
            },
            new Medlem { Fornavn = "Anna", Efternavn = "Lund", Email = "annalund@hotmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "Mathias", Efternavn = "Clausen", Email = "mathiasclaus@gmail.com", ErAktiv = false
            },
            new Medlem
            {
                Fornavn = "Caroline", Efternavn = "Bjerre", Email = "carobje22@gmail.com", ErAktiv = true
            },
            new Medlem { Fornavn = "Alberte", Efternavn = "Hviid", Email = "alb2005@hotmail.com", ErAktiv = true },
            new Medlem
            {
                Fornavn = "William", Efternavn = "Skov", Email = "Williamskov@hotmail.com", ErAktiv = true
            },
            new Medlem
            {
                Fornavn = "Josefine", Efternavn = "Laursen", Email = "joselaur@hotmail.com", ErAktiv = true
            },
        };
    }
}
// Medlems liste