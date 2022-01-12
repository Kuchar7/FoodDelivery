using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class UpdateRestaurantDtoValidator : AbstractValidator<UpdateRestaurantDto>
    {

        public UpdateRestaurantDtoValidator()
        {
            Include(new CommonRestaurantDtoValidator());
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be exists");
        }
    }
}
