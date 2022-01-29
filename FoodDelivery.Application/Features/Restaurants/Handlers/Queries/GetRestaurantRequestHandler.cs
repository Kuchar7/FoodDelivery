using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Requests;
using FoodDelivery.Application.Features.Restaurants.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Queries
{
    public class GetRestaurantRequestHandler : IRequestHandler<GetRestaurantRequest, RestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantRequestHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<RestaurantDto> Handle(GetRestaurantRequest request, CancellationToken cancellationToken)
        {
            var restaurant = await _restaurantRepository.Get(request.Id);
            if (restaurant == null)
                throw new NotFoundException(nameof(restaurant), request.Id);
            return _mapper.Map<RestaurantDto>(restaurant);
        }
    }
}
