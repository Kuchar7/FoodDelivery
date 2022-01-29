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

           
            
        }
    }
}
