using FoodDelivery.Domain.Common;

namespace FoodDelivery.Domain.Entities
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public int DishTypeId { get; set; }
        public DishType DishType { get; set; }
        public decimal Price { get; set; }

    }
}