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
            var ids = new List<int> { 1, 2 };
            var cuisineTypes = new List<CuisineType>
            {
                new CuisineType
                {
                    Id = 1,
                    Name = "Type1"
                },
                new CuisineType
                {
                    Id = 2,
                    Name = "Type2"
                }
            };
            var mockRepo = new Mock<ICuisineTypeRepository>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(cuisineTypes);
            mockRepo.Setup(r => r.Exist(It.IsIn<int>(ids))).ReturnsAsync(true);
            mockRepo.Setup(r => r.GetCuisineTypesByIds(ids)).ReturnsAsync(cuisineTypes);

            mockRepo.Setup(r => r.Add(It.IsAny<CuisineType>())).ReturnsAsync((CuisineType cuisineType) =>
            {
                cuisineTypes.Add(cuisineType);
                return cuisineType;
            });


            return mockRepo;
        }

    }
}
