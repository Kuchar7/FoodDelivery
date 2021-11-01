using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class IRestaurantDtoValidator : AbstractValidator<IRestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public IRestaurantDtoValidator(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Adresse.Country)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Adresse.Province)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Adresse.Street)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(p => p.Adresse.PostalCode)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Matches("[0-9]{2}-[0-9]{3}").WithMessage("Wrong format for postal code.");

            RuleFor(p => p.CuisinesTypesId)
                .NotNull().WithMessage("{PropertyName} is required.");

            RuleForEach(p => p.CuisinesTypesId)
                .MustAsync(async (id, token) =>
                {
                    var cuisineType = await _restaurantRepository.Exists(id);
                    return cuisineType;
                })
                .WithMessage("{PropertyName} deos not exists.");

        }
    }
}
