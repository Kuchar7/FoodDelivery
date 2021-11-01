using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Adresse
{
    public class CreateAdresseDto
    {
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
    }
}
