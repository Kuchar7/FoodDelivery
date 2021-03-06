using FoodDelivery.Domain.Common;
using System.Collections.Generic;

namespace FoodDelivery.Domain.Entities
{
    public class CuisineType : BaseEntity
    {
        public string Name { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}