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
        private readonly Mock<IRestaurantRepository> _mockRepoRestaurant;
        private readonly Mock<ICuisineTypeRepository> _mockRepoCuisineTypes;
        private readonly CreateRestaurantDto _createRestaurantDto;
        private readonly CreateRestaurantCommandHandler _handler;

        public CreateRestaurantCommandHandlerTest()
        {
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockRepoRestaurant = MockRestaurantRepository.GetRestaurantRepository();
            _mockRepoCuisineTypes = MockCuisineTypeRepository.GetCuisineTypeRepository();
            _handler = new CreateRestaurantCommandHandler(_mapper, _mockRepoRestaurant.Object, _mockRepoCuisineTypes.Object);
            _createRestaurantDto = new CreateRestaurantDto
            {
                City = "Test City",
                Description = "Test Description",
                Name = "Test Name",
                PostalCode = "05-220",
                Province = "Test Province",
                Street = "Test Street",
                HouseNumber = "1A",
                CuisineTypesIds = new List<int> { 1, 2}
            };
        }

        [Fact]
        public async Task CreateRestaurant_AddRestaurant_WhenCreateRestaurantDtoIsValid()
        {
            var result = await _handler.Handle(new CreateRestaurantCommand { CreateRestaurantDto = _createRestaurantDto }, CancellationToken.None);
            var restaurants = await _mockRepoRestaurant.Object.GetAll();
            result.ShouldBeOfType<int>();
            restaurants.Count.ShouldBe(3);
            var restaurant = restaurants.First(x => x.Id == result);
            restaurant.City.ShouldBeSameAs(_createRestaurantDto.City);
            restaurant.Description.ShouldBeSameAs(_createRestaurantDto.Description);
            restaurant.Name.ShouldBeSameAs(_createRestaurantDto.Name);
            restaurant.PostalCode.ShouldBeSameAs(_createRestaurantDto.PostalCode);
            restaurant.Province.ShouldBeSameAs(_createRestaurantDto.Province);
            restaurant.HouseNumber.ShouldBeSameAs(_createRestaurantDto.HouseNumber);
            restaurant.CuisinesTypes.Select(x => x.Id).ToList().ShouldBe(_createRestaurantDto.CuisineTypesIds);

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

            var restaurant = await _mockRepoRestaurant.Object.GetAll();

            restaurant.Count.ShouldBe(2);

        }

    }
}
