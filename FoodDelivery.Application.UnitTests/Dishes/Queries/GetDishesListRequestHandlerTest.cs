using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Dish;
using FoodDelivery.Application.Features.Dishes.Handlers.Queries;
using FoodDelivery.Application.Features.Dishes.Requests.Queries;
using FoodDelivery.Application.Profiles;
using FoodDelivery.Application.UnitTests.Mock;
using FoodDelivery.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FoodDelivery.Application.UnitTests.Dishes.Queries
{
    public class GetDishesListRequestHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IDishRepository> _mockRepoDish;
        public GetDishesListRequestHandlerTest()
        {
            _mockRepoDish = MockDishRepository.GetDishRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }
        [Fact]
        public async Task GetDishesList_GetListOfDishes_WhenDishesExist()
        {
            var handler = new GetDishesListRequestHandler(_mapper, _mockRepoDish.Object);
            var result = await handler.Handle(new GetDishesListRequest { RestaurantId = 1}, CancellationToken.None);
            result.ShouldBeOfType<List<DishDto>>();
            result.Count.ShouldBe(2);
        }
        [Fact]
        public async Task GetDishesList_GetEmptyList_WhenDishesNotExist()
        {
            var handler = new GetDishesListRequestHandler(_mapper, _mockRepoDish.Object);
            var result = await handler.Handle(new GetDishesListRequest { RestaurantId = 2 }, CancellationToken.None);
            result.ShouldBeOfType<List<DishDto>>();
            result.Count.ShouldBe(0);
        }
    }
}
