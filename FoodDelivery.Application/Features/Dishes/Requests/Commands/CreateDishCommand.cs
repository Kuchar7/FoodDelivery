using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.Dishes.Requests.Commands
{
    public class CreateDishCommand : IRequest<int>
    {
    }
}
