using FoodDelivery.Application.DTOs.Adresse;
using FoodDelivery.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public class UpdateRestaurantDto : BaseDto, IRestaurantDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CreateAdresseDto Adresse { get; set; }
        public List<int> CuisinesTypesId { get; set; }
    }
}
