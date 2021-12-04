using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
