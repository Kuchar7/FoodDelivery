using FoodDelivery.Application.DTOs.Common;

namespace FoodDelivery.Application.DTOs.Cuisine
{
    public class CuisineDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}