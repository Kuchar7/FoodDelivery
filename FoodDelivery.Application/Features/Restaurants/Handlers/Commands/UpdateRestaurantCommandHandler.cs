using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant.Validators;
using FoodDelivery.Application.Exception;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Commands
{
    public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;

        public UpdateRestaurantCommandHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<Unit> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateRestaurantDtoValidator(_restaurantRepository);
            var validatorResult = await validator.ValidateAsync(request.RestaurantDto);
            if (!validatorResult.IsValid)
                throw new ValidationException(validatorResult);
            var restaurant = await _restaurantRepository.Get(request.RestaurantDto.Id);
            _mapper.Map(request.RestaurantDto, restaurant);
            await _restaurantRepository.Update(restaurant);
            return Unit.Value;

        }
    }
}
