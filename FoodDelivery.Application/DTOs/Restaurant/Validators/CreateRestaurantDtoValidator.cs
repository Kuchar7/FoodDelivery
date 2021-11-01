using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class CreateRestaurantDtoValidator : AbstractValidator<CreateRestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public CreateRestaurantDtoValidator(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
            Include(new IRestaurantDtoValidator(_restaurantRepository));
            
        }
    }
}
