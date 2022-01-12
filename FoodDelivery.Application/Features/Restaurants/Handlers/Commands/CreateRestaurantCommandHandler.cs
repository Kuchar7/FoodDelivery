using AutoMapper;
using FoodDelivery.Application.Contracts.Infrastructure;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant.Validators;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Requests;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
using FoodDelivery.Application.Models;
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
        private readonly ICuisineTypeRepository _cuisineTypeRepository;
        private readonly IEmailSender _emailSender;

        public CreateRestaurantCommandHandler(IMapper mapper, IRestaurantRepository restaurantRepository, ICuisineTypeRepository cuisineTypeRepository/*, IEmailSender emailSender*/)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _cuisineTypeRepository = cuisineTypeRepository;
            //_emailSender = emailSender;
        }
        public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateRestaurantDtoValidator();

            var validationResult = await validator.ValidateAsync(request.CreateRestaurantDto);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult);
            
            var newRestaurant = _mapper.Map<Restaurant>(request.CreateRestaurantDto);
            newRestaurant.CuisinesTypes = new List<CuisineType>(await _cuisineTypeRepository.GetCuisineTypesByIds(request.CreateRestaurantDto.CuisineTypesIds));

            await _restaurantRepository.Add(newRestaurant);

            //var email = new Email
            //{
            //    To = "example@org.com",
            //    Body = $"Your restaurant {newRestaurant.Name} was added.",
            //    Subject = "New restaurant added."
            //};
            //try
            //{
            //    await _emailSender.SendEmail(email);
            //}
            //catch (Exception ex)
            //{

            //}

            return newRestaurant.Id;
        }
    }
}
