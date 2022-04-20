using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Dishes.Requests.Commands;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Dishes.Handlers.Commands
{
    public class DeleteDishCommandHandler : IRequestHandler<DeleteDishCommand, Unit>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        public DeleteDishCommandHandler(IDishRepository dishRepository, IRestaurantRepository restaurantRepository)
        {
            _dishRepository = dishRepository;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<Unit> Handle(DeleteDishCommand request, CancellationToken cancellationToken)
        {
            var isExist = await _restaurantRepository.Exist(request.RestaurantId);
            if (isExist == false)
                throw new NotFoundException(nameof(Restaurant), request.RestaurantId);
            var dish = await _dishRepository.Get(request.DishId);
            if (dish == null)
                throw new NotFoundException(nameof(Dish), request.DishId);
            await _dishRepository.Delete(dish);
            return Unit.Value;
        }
    }
}
