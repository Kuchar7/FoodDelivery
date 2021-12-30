using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Queries
{
    public class FindRestaurantRequest : IRequest<Unit>
    {
        public int RestaurantId { get; set; }
    }
}
