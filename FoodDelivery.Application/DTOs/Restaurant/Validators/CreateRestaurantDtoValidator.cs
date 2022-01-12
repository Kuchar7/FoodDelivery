using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class CreateRestaurantDtoValidator : AbstractValidator<CreateRestaurantDto>
    {

        public CreateRestaurantDtoValidator()
        {

            Include(new CommonRestaurantDtoValidator());

            RuleForEach(p => p.CuisineTypesIds)
                .NotNull().WithMessage("{PropertyName} is required.");





        }
    }
}
