using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Dish.Validators;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Dishes.Requests.Commands;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Dishes.Handlers.Commands
{
    class CreateDishCommandHandler : IRequestHandler<CreateDishCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IDishTypeRepository _dishTypeRepository;

        public CreateDishCommandHandler(IMapper mapper, IDishRepository dishRepository, IRestaurantRepository restaurantRepository, IDishTypeRepository dishTypeRepository)
        {
            _mapper = mapper;
            _dishRepository = dishRepository;
            _restaurantRepository = restaurantRepository;
            _dishTypeRepository = dishTypeRepository;
        }
        public async Task<int> Handle(CreateDishCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateDishDtoValidator(_restaurantRepository, _dishTypeRepository);
            var validationResult = await validator.ValidateAsync(request.DishDto, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult);

            var dish = _mapper.Map<Dish>(request.DishDto);
            await _dishRepository.Add(dish);
            return dish.Id;
        }
    }
}
