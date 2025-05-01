namespace HSejlklub.Models;

 public class Registration
    {
        public string Email { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }