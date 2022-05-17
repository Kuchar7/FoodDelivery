using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Models.Identity
{
    public class AuthResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string JwtToken { get; set; }
    }
}
