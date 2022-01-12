using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Requests.Queries;
using FoodDelivery.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Queries
{
    public class FindRestaurantRequestHandler : IRequestHandler<FindRestaurantRequest, Unit>
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public FindRestaurantRequestHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<Unit> Handle(FindRestaurantRequest request, CancellationToken cancellationToken)
        {
            var isExist = await _restaurantRepository.Exist(request.RestaurantId);
            if (isExist == false)
                throw new NotFoundException(nameof(Restaurant), request.RestaurantId);
            return Unit.Value;

        }
    }
}
