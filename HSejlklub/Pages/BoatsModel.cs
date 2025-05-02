using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using HSejlklub.Pages;
using HSejlklub.Models;

namespace HSejlklub.Pages
{
    public class BoatsModel : PageModel
    {
        // Separate lists for our boats
        public List<Sailboat> Sailboats { get; set; }
        public List<Motorboat> Motorboats { get; set; }
        public List<Boats> BoatsList { get; set; }

        public void OnGet()
        {
            Sailboats = new List<Sailboat>
            {
                new Sailboat(1, "Luna", "Sailboat", "09876", "Yamaha 4HP", 2010, true, 2, "sailboat1"),
                new Sailboat(2, "Asta", "Sailboat", "54321", "Honda 10HP", 2015, false, 3, "sailboat2"),
                new Sailboat(3, "Sarah", "Sailboat", "121212", "Tohatsu 6HP", 2018, true, 2, "sailboat3"),
                new Sailboat(4, "Yasmine", "Sailboat", "252525", "Mercury 8HP", 2022, true, 1, "sailboat4")
            };

            Motorboats = new List<Motorboat>
            {
                new Motorboat(3, "Tina", "Motorboat", "54321", "Suzuki 15HP", 2018, true, "4-stroke", "motorboat1.jpg"),
                new Motorboat(4, "Trine", "Motorboat", "09876", "Yamaha 20HP", 2020, false, "2-stroke", "motorboat2.jpg"),
                new Motorboat(5, "Bella", "Motorboat", "11223", "Mercury 25HP", 2021, true, "4-stroke", "motorboat3.jpg"),
                new Motorboat(6, "Nova", "Motorboat", "33445", "Honda 30HP", 2019, true, "4-stroke", "motorboat4.jpg")
            };

            BoatsList = new List<Boats>
            {

            };
        }
    }
}