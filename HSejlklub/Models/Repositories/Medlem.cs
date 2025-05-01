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
                new Medlem { Fornavn = "William", Efternavn = "Jensen", Email = "williamj@hotmail.com", ErAktiv = true },
                new Medlem { Fornavn = "Ida", Efternavn = "Larsen", Email = "ida.l@live.dk", ErAktiv = false },
                new Medlem {Fornavn = "Mads", Efternavn = "Dalberg", Email = "madsdalb@hotmail.com", ErAktiv = true},
                new Medlem { Fornavn = "Sophie", Efternavn = "Pedersen", Email = ""}
            };
        }
    }

// Medlems liste