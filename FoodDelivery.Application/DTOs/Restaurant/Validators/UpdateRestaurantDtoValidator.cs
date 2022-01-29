using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class UpdateRestaurantDtoValidator : AbstractValidator<UpdateRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;
        public UpdateRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            Include(new CommonRestaurantDtoValidator(_cuisineTypeRepository));
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be exists");
        }
    }
}
