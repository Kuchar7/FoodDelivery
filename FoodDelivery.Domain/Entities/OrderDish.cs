using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class OrderDish : BaseEntity
    {
        public int Quantity { get; set; }
        public int? DishId { get; set; }
        public Dish Dish { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
