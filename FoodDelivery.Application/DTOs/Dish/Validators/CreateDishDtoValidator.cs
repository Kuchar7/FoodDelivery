using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Dish.Validators
{
    public class CreateDishDtoValidator : AbstractValidator<CreateDishDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IDishTypeRepository _dishTypeRepository;

        public CreateDishDtoValidator(IRestaurantRepository restaurantRepository, IDishTypeRepository dishTypeRepository)
        {
            _restaurantRepository = restaurantRepository;
            _dishTypeRepository = dishTypeRepository;
            Include(new CommonDishDtoValidator(_restaurantRepository, _dishTypeRepository));
            
        }

    }
}

