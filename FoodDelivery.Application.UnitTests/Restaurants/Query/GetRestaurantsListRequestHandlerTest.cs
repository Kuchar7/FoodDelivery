using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Features.Restaurants.Handlers.Queries;
using FoodDelivery.Application.Features.Restaurants.Requests.Queries;
using FoodDelivery.Application.Profiles;
using FoodDelivery.Application.UnitTests.Mock;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FoodDelivery.Application.UnitTests.Restaurants.Query
{
    public class GetRestaurantsListRequestHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRestaurantRepository> _mockRepo;

        public GetRestaurantsListRequestHandlerTest()
        {
            _mockRepo = MockRestaurantRepository.GetRestaurantRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }


        [Fact]
        public async Task GetRestaurantsListTest()  
        {
            var handler = new GetRestaurantsListRequestHandler(_mockRepo.Object, _mapper);
            var result = await handler.Handle(new GetRestaurantsListRequest(), CancellationToken.None);
            result.ShouldBeOfType<List<RestaurantDto>>();
            result.Count.ShouldBe(2);
        }

    }
}
