using FluentValidation;
using FoodDelivery.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.DTOs.Dish.Validators
{
    public class CommonDishDtoValidator : AbstractValidator<IDishDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IDishTypeRepository _dishTypeRepository;

        public CommonDishDtoValidator(IRestaurantRepository restaurantRepository, IDishTypeRepository dishTypeRepository)
        {
            _restaurantRepository = restaurantRepository;
            _dishTypeRepository = dishTypeRepository;

            RuleFor(d => d.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(60).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(d => d.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(150).WithMessage("{PropertyName} must not exceed {ComparisionValue} characters.");

            RuleFor(d => d.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .ScalePrecision(2, 6);

            RuleFor(d => d.RestaurantId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MustAsync(async (restaurantId, token) =>
                {
                    bool exist = await _restaurantRepository.Exist(restaurantId);
                    return exist;
                }).WithMessage("{PropertyName} doesn't exists.");

            RuleFor(d => d.DishTypeId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MustAsync(async (dishTypeId, token) =>
                {
                    bool exist = await _dishTypeRepository.Exist(dishTypeId);
                    return exist;
                }).WithMessage("{PropertyName} doesn't exists.");


        }
    }
}
