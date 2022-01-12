using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.Features.Dishes.Requests.Queries;
using FoodDelivery.Application.Features.Restaurants.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Api.Controllers
{
    [Route("api/restaurant/{restaurantId}/dish")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DishesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<DishDto>>> Get([FromRoute] int restaurantId)
        {
            await _mediator.Send(new FindRestaurantRequest { RestaurantId = restaurantId });
            var dishes =  await _mediator.Send(new GetDishesListRequest { RestaurantId = restaurantId });
            return Ok(dishes);
        }

    }
}
