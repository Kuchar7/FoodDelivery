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
        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }
        public decimal RestaurantRate {get; set;}
        public List<Dish> Dishes { get; set; }
        public List<CuisineType> CuisinesTypes { get; set; }

    }
}
