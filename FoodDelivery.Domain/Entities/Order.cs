using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int? OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Note { get; set; }
        public List<OrderDish> OrderDishes { get; set; }
        public string UserId { get; set; }
        public int? DeliveryManId { get; set; }
        public DeliveryMan DeliveryMan { get; set; }
    }
}
