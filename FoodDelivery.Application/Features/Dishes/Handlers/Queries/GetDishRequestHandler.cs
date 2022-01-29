using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Dishes.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Dishes.Handlers.Queries
{
    public class GetDishRequestHandler : IRequestHandler<GetDishRequest, DishDto>
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;

        public GetDishRequestHandler(IMapper mapper, IDishRepository dishRepository)
        {
            _mapper = mapper;
            _dishRepository = dishRepository;
        }
        public async Task<DishDto> Handle(GetDishRequest request, CancellationToken cancellationToken)
        {
            var dish = await _dishRepository.GetSpecificDish(request.RestaurantId, request.DishId);
            if (dish == null)
                throw new NotFoundException(nameof(dish), request.DishId);

            return _mapper.Map<DishDto>(dish);
        }
    }
}
