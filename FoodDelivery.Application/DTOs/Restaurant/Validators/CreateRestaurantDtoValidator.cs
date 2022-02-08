using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Restaurant.Validators
{
    public class CreateRestaurantDtoValidator : AbstractValidator<CreateRestaurantDto>
    {
        private readonly ICuisineTypeRepository _cuisineTypeRepository;

        public CreateRestaurantDtoValidator(ICuisineTypeRepository cuisineTypeRepository)
        {
            _cuisineTypeRepository = cuisineTypeRepository;

            Include(new CommonRestaurantDtoValidator(_cuisineTypeRepository));
            RuleFor(p => p.CuisineTypesIds)
            .NotNull().WithMessage("{PropertyName} is required.");

            RuleForEach(p => p.CuisineTypesIds)
                .MustAsync(async (id, token) =>
                {
                    var exist = await _cuisineTypeRepository.Exist(id);
                    return exist;
                }).WithMessage("Cuisine type doesn't exist for the given ID ({PropertyValue}).");



        }
    }
}
