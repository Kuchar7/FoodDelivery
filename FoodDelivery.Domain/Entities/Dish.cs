using FoodDelivery.Domain.Common;
using System.Collections.Generic;

namespace FoodDelivery.Domain.Entities
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public int? DishTypeId { get; set; }
        public DishType DishType { get; set; }
        public decimal Price { get; set; }
        public List<OrderDish> OrderDishes { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}