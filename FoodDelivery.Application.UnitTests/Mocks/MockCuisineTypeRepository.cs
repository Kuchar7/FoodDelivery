using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.UnitTests.Mock
{
    public static class MockCuisineTypeRepository
    {
        public static Mock<ICuisineTypeRepository> GetCuisineTypeRepository()
        {
            var cuisineTypes = new List<CuisineType>
            {
                new CuisineType
                {
                    Id = 1,
                    Name = "Polish"
                },
                new CuisineType
                {
                    Id = 2,
                    Name = "Georgian"
                }
            };
            var mockRepo = new Mock<ICuisineTypeRepository>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(cuisineTypes);

            mockRepo.Setup(r => r.Add(It.IsAny<CuisineType>())).ReturnsAsync((CuisineType cuisineType) =>
            {
                cuisineTypes.Add(cuisineType);
                return cuisineType;
            });


            return mockRepo;
        }

    }
}
