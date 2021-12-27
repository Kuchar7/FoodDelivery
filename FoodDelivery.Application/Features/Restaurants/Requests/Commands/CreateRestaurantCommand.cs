using FoodDelivery.Application.DTOs.Restaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Commands
{
    public class CreateRestaurantCommand : IRequest<int>
    {
        public CreateRestaurantDto CreateRestaurantDto { get; set; }
    }
}
