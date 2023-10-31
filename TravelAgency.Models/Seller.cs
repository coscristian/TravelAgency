
namespace TravelAgency.Models
{
    public class Seller : Person
    {
        public Sucursal Sucursal { get; set; }

        public GeneralAdmin GeneralAdmin { get; set; }
    }
}
