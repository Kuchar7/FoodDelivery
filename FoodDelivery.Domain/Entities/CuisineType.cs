using FoodDelivery.Domain.Common;

namespace FoodDelivery.Domain.Entities
{
    public class CuisineType : BaseEntity
    {
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}