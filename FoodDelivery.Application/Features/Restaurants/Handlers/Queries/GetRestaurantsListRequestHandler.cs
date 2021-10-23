using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Features.Restaurants.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Restaurants.Handlers.Queries
{
    public class GetRestaurantsListRequestHandler : IRequestHandler<GetRestaurantsListRequest, List<RestaurantDto>>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantsListRequestHandler(IRestaurantRepository restaurantRepository, IMapper mapper )
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }
        public async Task<List<RestaurantDto>> Handle(GetRestaurantsListRequest request, CancellationToken cancellationToken)
        {
            var restaurants = await _restaurantRepository.GetAll();
            return _mapper.Map<List<RestaurantDto>>(restaurants);
        }
    }
}
