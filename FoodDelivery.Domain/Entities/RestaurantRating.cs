﻿using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class RestaurantRating : BaseEntity
    {
        public int Rating { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
