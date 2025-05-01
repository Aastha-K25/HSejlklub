
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using HSejlklub.Models.Repositories;
using System.Collections.Generic;
using HSejlklub.Pages;

public class Medlem
{
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public string Email { get; set; }
    public bool ErAktiv { get; set; }
}
