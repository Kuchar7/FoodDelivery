using FoodDelivery.Application.DTOs.Common;

namespace FoodDelivery.Application.DTOs
{
    public class DishDto : BaseDto
    {
        public string Name { get; set; }
        public int DishTypeId { get; set; }
        public DishTypeDto DishType { get; set; }
        public decimal Price { get; set; }
    }
}