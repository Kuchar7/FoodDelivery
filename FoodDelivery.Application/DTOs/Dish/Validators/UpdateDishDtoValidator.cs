using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Dish.Validators
{
    public class UpdateDishDtoValidator : AbstractValidator<UpdateDishDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IDishTypeRepository _dishTypeRepository;
        private readonly IDishRepository _dishRepository;
        public UpdateDishDtoValidator(IRestaurantRepository restaurantRepository, IDishTypeRepository dishTypeRepository, IDishRepository dishRepository)
        {
            _restaurantRepository = restaurantRepository;
            _dishTypeRepository = dishTypeRepository;
            _dishRepository = dishRepository;
            Include(new CommonDishDtoValidator(_restaurantRepository, _dishTypeRepository));
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be exists");
            RuleFor(p => p.Id)
               .MustAsync(async (id, token) =>
               {
                   var exist = await _dishRepository.Exist(id);
                   return exist;
               }).WithMessage("Dish doesn't exist for the given ID ({PropertyValue}).");

        }
    }
}
