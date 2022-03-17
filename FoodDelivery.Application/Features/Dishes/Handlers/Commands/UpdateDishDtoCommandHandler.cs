using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Dish.Validators;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Dishes.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Dishes.Handlers.Commands
{
    public class UpdateDishDtoCommandHandler : IRequestHandler<UpdateDishCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IDishRepository _dishRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IDishTypeRepository _dishTypeRepository;
        public UpdateDishDtoCommandHandler(IMapper mapper, IDishRepository dishRepository, IRestaurantRepository restaurantRepository, IDishTypeRepository dishTypeRepository)
        {
            _mapper = mapper;
            _dishRepository = dishRepository;
            _restaurantRepository = restaurantRepository;
            _dishTypeRepository = dishTypeRepository;
        }



        public async Task<Unit> Handle(UpdateDishCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateDishDtoValidator(_restaurantRepository, _dishTypeRepository, _dishRepository);
            var validationResult = await validator.ValidateAsync(request.DishDto);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult);
            var dish = await _dishRepository.Get(request.DishDto.Id);
            if (dish == null)
                throw new NotFoundException(nameof(dish), request.DishDto.Id);
            _mapper.Map(request.DishDto, dish);
            await _dishRepository.Update(dish);
            return Unit.Value;
        }
    }
}

