using FoodDelivery.Application.DTOs.Restaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Queries
{
    public class GetRestaurantRequest : IRequest<RestaurantDto>
    {
        public GetRestaurantRequest(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }
    }
}
