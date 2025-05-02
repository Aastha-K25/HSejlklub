using HSejlklub.Models;

namespace HSejlklub.Pages

{
    // Sailboat class inheriting from Boats
    public class Sailboat : Boats
    {
        // Sailboat-specific properties can be added here if needed
        public int NumberOfSails { get; set; }
        // Constructor for Sailboat class
        public Sailboat(int boatID, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable, int numberOfSails, string imagePath) : base(boatID, name, model, sailNumber, engineInfo, buildYear, isAvailable, imagePath)
        {
            NumberOfSails = numberOfSails;
        }
    }
}
