using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Domain.Entities
{
    public class User : BaseEntity 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public int FloorNumber { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
        public List<RestaurantRating> RestaurantRatings { get; set; }
        public Manager Manager { get; set; }
        public DeliveryMan DeliveryMan { get; set; }


    }
}
