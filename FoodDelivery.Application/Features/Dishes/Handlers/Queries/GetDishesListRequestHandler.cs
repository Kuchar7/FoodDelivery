using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Dishes.Requests.Queries;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Dishes.Handlers.Queries
{
    public class GetDishesListRequestHandler : IRequestHandler<GetDishesListRequest, List<DishDto>>
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        public GetDishesListRequestHandler(IMapper mapper, IDishRepository dishRepository)
        {
            _mapper = mapper;
            _dishRepository = dishRepository;
        }

        public async Task<List<DishDto>> Handle(GetDishesListRequest request, CancellationToken cancellationToken)
        {
            var dishes = await _dishRepository.GetAllDishesByRestaurantId(request.RestaurantId);
            
            return _mapper.Map<List<DishDto>>(dishes);
        }
    }
}
