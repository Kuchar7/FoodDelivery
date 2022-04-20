using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Dishes.Requests.Commands
{
    public class DeleteDishCommand : IRequest<Unit>
    {
        public int DishId { get; set; }
        public int RestaurantId { get; set; }
    }
}
