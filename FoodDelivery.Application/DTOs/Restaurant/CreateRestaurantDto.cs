using FoodDelivery.Application.DTOs.Adresse;
using FoodDelivery.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public class CreateRestaurantDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AdresseDto Adresse { get; set; }
        public int [] CuisinesTypesId { get; set; }
    }
}
