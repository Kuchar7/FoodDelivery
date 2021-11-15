using FoodDelivery.Application.DTOs.Cuisine;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Features.CuisineTypes.Requests.Queries
{
    public class GetCuisineTypesListRequest : IRequest<List<CuisineTypeDto>>
    {
    }
}
