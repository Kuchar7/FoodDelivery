using FoodDelivery.Application.DTOs.Restaurant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Queries
{
    public class GetRestaurantsListRequest : IRequest<List<RestaurantDto>>
    {

    }
}
