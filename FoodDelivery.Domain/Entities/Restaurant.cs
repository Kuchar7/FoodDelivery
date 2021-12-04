using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<CuisineType> CuisinesTypes { get; set; }
        public List<Manager> Managers { get; set; }
        public List<RestaurantRating> RestaurantRatings { get; set; }

    }
}
