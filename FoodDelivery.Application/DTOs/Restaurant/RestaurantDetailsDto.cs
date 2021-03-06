using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.DTOs.Dish;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public class RestaurantDetailsDto : IRestaurantDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<DishDto> Dishes { get; set; }
        public List<CuisineTypeDto> CuisinesTypes { get; set; }
    }
}
