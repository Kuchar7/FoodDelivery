using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Application.Features.Restaurants.Handlers.Commands;
using FoodDelivery.Application.Profiles;
using FoodDelivery.Application.UnitTests.Mock;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FoodDelivery.Application.UnitTests.Restaurants.Command
{
    public class UpdateRestaurantCommandHandlerTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IRestaurantRepository> _mockRepoRestaurant;
        private readonly Mock<ICuisineTypeRepository> _mockRepoCuisineTypes;
        private readonly UpdateRestaurantDto _updateRestaurantDto;
        private readonly UpdateRestaurantCommandHandler _handler;


        public UpdateRestaurantCommandHandlerTest()
        {
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockRepoRestaurant = MockRestaurantRepository.GetRestaurantRepository();
            _mockRepoCuisineTypes = MockCuisineTypeRepository.GetCuisineTypeRepository();
            _handler = new UpdateRestaurantCommandHandler(_mapper, _mockRepoRestaurant.Object, _mockRepoCuisineTypes.Object);
 
        }

        //[Fact]
        //public async Task UpdateRestaurant_AddRestaurant_WhenUpdateRestaurantDtoIsValid()
        //{

        //}


    }
}
