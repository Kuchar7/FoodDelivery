using FoodDelivery.Application.DTOs.Common;
using FoodDelivery.Application.DTOs.DishType;

namespace FoodDelivery.Application.DTOs.Dish
{
    public class DishDto : BaseDto, IDishDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DishTypeId { get; set; }
        public DishTypeDto DishType { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; }
    }
}