using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Handlers.Queries;
using FoodDelivery.Application.Features.Restaurants.Requests.Queries;
using FoodDelivery.Application.UnitTests.Mock;
using MediatR;
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
    public class FindRestaurantRequestHandlerTest
    {
        private readonly Mock<IRestaurantRepository> _mockRepo;
        private readonly int _restaurantId;

        public FindRestaurantRequestHandlerTest()
        {
            _mockRepo = MockRestaurantRepository.GetRestaurantRepository();
            _restaurantId = 1;
        }

        //[Fact]
        //public async Task FindRestaurant_NotThrowsException_WhenRestaurantExist()
        //{
        //    var result = await _handler.Handle(new FindRestaurantRequest { RestaurantId = _restaurantId }, CancellationToken.None);

        //    result.ShouldBeOfType<Unit>();
        //}

        //[Fact]
        //public async Task FindRestaurant_ThrowsException_WhenRestaurantNotExist()
        //{
        //     await Should.ThrowAsync<NotFoundException>
        //        (
        //        async () =>
        //        await _handler.Handle(new FindRestaurantRequest { RestaurantId = 0 }, CancellationToken.None)
        //        );
        //}
    }
}
