using FoodDelivery.Application.DTOs.Cuisine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant
{
    public interface IRestaurantDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<int> CuisineTypesIds { get; set; }

        //public List<CuisineTypeDto> CuisineTypes { get; set; }
    }
}
