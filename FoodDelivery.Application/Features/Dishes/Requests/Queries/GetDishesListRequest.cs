using FoodDelivery.Application.DTOs.Dish;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Dishes.Requests.Queries
{
    public class GetDishesListRequest : IRequest<List<DishDto>>
    {
        public int RestaurantId { get; set; }
    }
}
