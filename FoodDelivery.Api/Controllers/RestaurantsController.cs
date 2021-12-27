using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
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
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RestaurantsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/restaurants
        [HttpGet]
        public async Task<ActionResult<List<RestaurantDto>>> Get()
        {
            var restaurants = await _mediator.Send(new GetRestaurantsListRequest());
            return Ok(restaurants);
        }

        // GET: api/restaurants/id
        [HttpGet("{id}")]
        public async Task<ActionResult<RestaurantDto>> Get(int id)
        {
            var restaurant = await _mediator.Send(new GetRestaurantDetailsRequest(id));
            return Ok(restaurant);
        }

        //Post: api/restaurants
        [HttpPost]
        public async Task<ActionResult> Post ([FromBody] CreateRestaurantDto restaurant)
        {
            var newRestaurantId = await _mediator.Send(new CreateRestaurantCommand { CreateRestaurantDto = restaurant });
            return Created($"api/restaurants/{newRestaurantId}", null);
        }

        //Put: api/restaurants/id
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] UpdateRestaurantDto restaurantDto)
        {
            await _mediator.Send(new UpdateRestaurantCommand { RestaurantDto = restaurantDto });
            return NoContent();
        }

        //Delete: api/restaurants/id
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRestaurantCommand { Id = id });
            return NoContent();
        }
    }
}
