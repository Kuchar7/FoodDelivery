﻿using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
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
    public class GetRestaurantDetailsRequestHandler : IRequestHandler<GetRestaurantDetailsRequest, RestaurantDto>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetRestaurantDetailsRequestHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<RestaurantDto> Handle(GetRestaurantDetailsRequest request, CancellationToken cancellationToken)
        {
            var restaurant = await _restaurantRepository.Get(request.Id);
            return _mapper.Map<RestaurantDto>(restaurant);
        }
    }
}
