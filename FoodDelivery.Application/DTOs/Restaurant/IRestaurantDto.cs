using FoodDelivery.Application.DTOs.Adresse;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public interface IRestaurantDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CreateAdresseDto Adresse { get; set; }
        public List<int> CuisinesTypesId { get; set; }
    }
}
