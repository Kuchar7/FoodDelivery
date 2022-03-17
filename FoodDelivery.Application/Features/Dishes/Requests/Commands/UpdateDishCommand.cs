using FoodDelivery.Application.DTOs.Dish;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Dishes.Requests.Commands
{
    public class UpdateDishCommand : IRequest<Unit>
    {
        public UpdateDishDto DishDto { get; set; }
    }
}
