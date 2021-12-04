using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class DeliveryMan : BaseEntity
    {
        public List<Order> Orders { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
