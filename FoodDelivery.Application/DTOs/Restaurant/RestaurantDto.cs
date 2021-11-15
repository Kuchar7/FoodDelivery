using FoodDelivery.Application.DTOs.Adresse;
using FoodDelivery.Application.DTOs.Common;
using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.DTOs.Dish;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public class RestaurantDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AdresseId { get; set; }
        public AdresseDto Adresse { get; set; }
        public decimal RestaurantRate { get; set; }
        public List<DishDto> Dishes { get; set; }
        public List<CuisineTypeDto> CuisinesTypes { get; set; }
    }
}
