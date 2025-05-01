
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using HSejlklub.Models.Repositories;

namespace HSejlklub.Models

{
    public class MedlemslisteModel : PageModel
    {
        public List<Medlem> Medlemmer { get; set; }

        public void OnGet()
        {
            Medlemmer = new List<Medlem>
            {
                new Medlem { Fornavn = "Emma", Efternavn = "Hansen", Email = "emma.hansen@mail.dk", ErAktiv = true },
                new Medlem { Fornavn = "Lucas", Efternavn = "Møller", Email = "lucas.m@outlook.com", ErAktiv = false },
                new Medlem { Fornavn = "Freja", Efternavn = "Andersen", Email = "freja_a@gmail.com", ErAktiv = true },
                new Medlem { Fornavn = "William", Efternavn = "Jensen", Email = "williamj@hotmail.com", ErAktiv = true },
                new Medlem { Fornavn = "Ida", Efternavn = "Larsen", Email = "ida.l@live.dk", ErAktiv = false },
                // Tilføj flere op til 15-20
            };
        }
    }
}