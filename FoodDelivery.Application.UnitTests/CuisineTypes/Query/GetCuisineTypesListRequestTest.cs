using AutoMapper;
using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Cuisine;
using FoodDelivery.Application.Features.CuisineTypes.Handlers.Queries;
using FoodDelivery.Application.Features.CuisineTypes.Requests.Queries;
using FoodDelivery.Application.Profiles;
using FoodDelivery.Application.UnitTests.Mocks;
using FoodDelivery.Domain.Entities;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace FoodDelivery.Application.UnitTests.CuisineTypes.Query
{
    public class GetCuisineTypesListRequestTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICuisineTypeRepository> _mockRepo;

        public GetCuisineTypesListRequestTest()
        {
            _mockRepo = MockCuisineTypeRepository.GetCuisineTypeRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }




        [Fact]
        public async Task GetCuisineTypeListTest()
        {
            var handler = new GetCuisineTypesListRequestHandler(_mapper, _mockRepo.Object);
            var result = await handler.Handle(new GetCuisineTypesListRequest(), CancellationToken.None);
            result.ShouldBeOfType<List<CuisineTypeDto>>();
            result.Count.ShouldBe(2);
        }
    }

}
