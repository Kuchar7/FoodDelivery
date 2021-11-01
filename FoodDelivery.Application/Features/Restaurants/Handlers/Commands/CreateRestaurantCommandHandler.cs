using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant.Validators;
using FoodDelivery.Application.Exception;
using FoodDelivery.Application.Features.Restaurants.Requests;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Commands
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateRestaurantCommandHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateRestaurantDtoValidator(_restaurantRepository);

            var validationResult = await validator.ValidateAsync(request.RestaurantDto);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult);
            }

            var newRestaurant = _mapper.Map<Restaurant>(request.RestaurantDto);
            await _restaurantRepository.Add(newRestaurant);
            return newRestaurant.Id;
        }
    }
}
