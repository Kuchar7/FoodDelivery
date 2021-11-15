using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.Features.CuisineTypes.Requests.Queries;
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
    public class CuisineTypesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CuisineTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/cuisinetypes
        [HttpGet]
        public async Task<ActionResult<List<CuisineTypeDto>>> Get()
        {
            var cuisineTypes = await _mediator.Send(new GetCuisineTypesListRequest());
            return cuisineTypes;
        }
    }
}
