using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public Stylist Stylist { get; set; }
    }
}