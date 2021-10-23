using FoodDelivery.Application.DTOs.Common;

namespace FoodDelivery.Application.DTOs
{
    public class AdresseDto : BaseDto
    {
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
    }
}