using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.Features.Dishes.Requests.Commands;
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
    [Route("api/restaurant/{restaurantId}/dishes")]
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
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateDishDto dishDto)
        {
            var dishId = await _mediator.Send(new CreateDishCommand { DishDto = dishDto });
            return Created($"api/restaurant/{dishDto.RestaurantId}/dishes/{dishId}", null);
        }

    }
}
