using FoodDelivery.Domain.Common;

namespace FoodDelivery.Domain.Entities
{
    public class Adresse : BaseEntity
    {
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
    }
}