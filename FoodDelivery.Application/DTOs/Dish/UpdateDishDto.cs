using FoodDelivery.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Dish
{
    public class UpdateDishDto : BaseDto, IDishDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DishTypeId { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get ; set; }
    }
}
