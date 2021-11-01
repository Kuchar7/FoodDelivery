using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Restaurants.Requests.Commands
{
    public class DeleteRestaurantCommand : IRequest
    {
        public int Id { get; set; }
    }
}
