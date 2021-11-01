using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class UpdateRestaurantDtoValidator : AbstractValidator<UpdateRestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public UpdateRestaurantDtoValidator(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
            Include(new IRestaurantDtoValidator(_restaurantRepository));
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be exists");
        }
    }
}
