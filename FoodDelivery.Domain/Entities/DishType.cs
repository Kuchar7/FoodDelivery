using FoodDelivery.Domain.Common;
using System.Collections.Generic;

namespace FoodDelivery.Domain.Entities
{
    public class DishType : BaseEntity
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}