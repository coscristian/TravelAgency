using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models
{
    public abstract class Person
    {
        public Guid Guid { get; set; }
        
        public string Id { get; set; } = string.Empty;
        
        public string Name { get; set; } = string.Empty;
        
        public string LastName { get; set; } = string.Empty;
        
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        public Street Street { get; set; }
    }
}
