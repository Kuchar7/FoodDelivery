using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class Manager : BaseEntity
    {
        public List<Restaurant> Restaurants { get; set; }
        public string UserId { get; set; }
    }
}
