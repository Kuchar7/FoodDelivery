using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Commands
{
    public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public DeleteRestaurantCommandHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public async Task<Unit> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurant = await _restaurantRepository.Get(request.Id);
            if (restaurant == null)
                throw new NotFoundException(nameof(Restaurant), request.Id);
            await _restaurantRepository.Delete(restaurant);
            return Unit.Value;
        }
    }
}
