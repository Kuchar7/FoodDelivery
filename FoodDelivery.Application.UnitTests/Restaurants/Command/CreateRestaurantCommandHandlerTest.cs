using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Exceptions;
using FoodDelivery.Application.Features.Restaurants.Handlers.Commands;
using FoodDelivery.Application.Features.Restaurants.Requests.Commands;
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

namespace FoodDelivery.Application.UnitTests.Restaurants.Command
{
    public class CreateRestaurantCommandHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRestaurantRepository> _mockRepo;
        private readonly CreateRestaurantDto _createRestaurantDto;
        private readonly CreateRestaurantCommandHandler _handler;

        public CreateRestaurantCommandHandlerTest()
        {
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockRepo = MockRestaurantRepository.GetRestaurantRepository();
            _handler = new CreateRestaurantCommandHandler(_mapper, _mockRepo.Object);
            _createRestaurantDto = new CreateRestaurantDto
            {
                City = "Test City",
                Description = "Test Description",
                Name = "Test Name",
                PostalCode = "05-220",
                Province = "Test Province",
                Street = "Test Street",
                HouseNumber = "1A",
                CuisineTypeDtos = new List<DTOs.Cuisine.CuisineTypeDto>
                {
                    new CuisineTypeDto
                    {
                        Id = 1,
                        Name = "Test Name1"
                    },
                    new CuisineTypeDto
                    {
                        Id = 2,
                        Name = "Test Name2"
                    }
                }
            };
        }

        [Fact]
        public async Task CreateRestaurant_AddRestaurant_WhenCreateRestaurantDtoIsValid()
        {
            var result = await _handler.Handle(new CreateRestaurantCommand { CreateRestaurantDto = _createRestaurantDto }, CancellationToken.None);
            var restaurant = await _mockRepo.Object.GetAll();
            result.ShouldBeOfType<int>();
            restaurant.Count.ShouldBe(3);
        }

        [Fact]
        public async Task CreateRestaurant_ThrowsException_WhenNameIsNull()
        {
            _createRestaurantDto.Name = "";
            await Should.ThrowAsync<ValidationException>
                (
                async () =>
                await _handler.Handle(new CreateRestaurantCommand { CreateRestaurantDto = _createRestaurantDto }, CancellationToken.None)
                );

            var restaurant = await _mockRepo.Object.GetAll();

            restaurant.Count.ShouldBe(2);

        }

    }
}
