using FoodDelivery.Application.DTOs.Restaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Queries
{
    public class GetRestaurantDetailsRequest : IRequest<RestaurantDto>
    {
        public int Id { get; set; }
    }
}
