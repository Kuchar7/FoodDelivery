using FoodDelivery.Application.DTOs.DishType;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Dish
{
    public class CreateDishDto : IDishDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DishTypeId { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }
        
    }
}
