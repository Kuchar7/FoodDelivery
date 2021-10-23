using FoodDelivery.Application.DTOs.Restaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests
{
    public class GetRestaurantsListRequest : IRequest<List<RestaurantDto>>
    {

    }
}
