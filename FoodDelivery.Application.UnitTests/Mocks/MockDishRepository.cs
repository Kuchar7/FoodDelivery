using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.UnitTests.Mocks
{
    public static class MockDishRepository
    {
        public static Mock<IDishRepository> GetDishRepository()
        {
            var dishType1 = new DishType
            {
                Id = 1,
                Name = "Test1"
            };
            var dishType2 = new DishType
            {
                Id = 2,
                Name = "Test2"
            };

            var dishes = new List<Dish>
            {
                new Dish
                {
                    Id = 1,
                    Name = "Test1",
                    Price = 20.50M,
                    RestaurantId = 1,
                    DishTypeId = 1,
                    DishType = dishType1
                },
                new Dish
                {
                    Id = 2,
                    Name = "Test2",
                    Price = 15.50M,
                    RestaurantId = 1,
                    DishTypeId = 2,
                    DishType = dishType2
                }
            };
            int selectedRestaurantId = 1;

            var mockRepo = new Mock<IDishRepository>();
            //mockRepo.Setup(m => m.GetSpecificDish(selectedRestaurantId)).ReturnsAsync(dishes.Where(d => d.RestaurantId == selectedRestaurantId).ToList);

            return mockRepo;
        }
    }
}
