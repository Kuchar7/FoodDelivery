using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class CommonRestaurantDtoValidator : AbstractValidator<IRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public CommonRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");


            RuleFor(p => p.Province)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Street)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.PostalCode)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Matches("[0-9]{2}-[0-9]{3}").WithMessage("Wrong format for postal code.");



        }
    }
}
