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
    public static class MockRestaurantRepository
    {
        public static Mock<IRestaurantRepository> GetRestaurantRepository()
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "TestRestaurant1",
                    City = "TestCity1",
                    Description = "TestDescription1",
                    Street = "TestStreet1",
                    Province = "TestProvince1",
                    HouseNumber = "1",
                    PostalCode = "00-001",
                    DateCreated = DateTime.Now,
                    RestaurantRatings = new List<RestaurantRating>
                    {
                        new RestaurantRating
                        {
                            RestaurantId = 1,
                            UserId = 1,
                            DateCreated = DateTime.Now,
                            Rating = 4
                        },
                        new RestaurantRating
                        {
                            RestaurantId = 1,
                            UserId = 2,
                            DateCreated = DateTime.Now,
                            Rating = 5
                        },
                        new RestaurantRating
                        {
                            RestaurantId = 1,
                            UserId = 3,
                            DateCreated = DateTime.Now,
                            Rating = 4
                        }
                    },
                    CuisinesTypes = new List<CuisineType>
                    {
                        new CuisineType
                        {
                            Id = 1,
                            DateCreated = DateTime.Now,
                            Name = "Type1"
                        },
                        new CuisineType
                        {
                            Id = 2,
                            DateCreated = DateTime.Now,
                            Name = "Type2"
                        }
                    },
                    Managers = new List<Manager>
                    {
                        new Manager
                        {
                            Id = 1,
                            DateCreated = DateTime.Now,
                            UserId = 4
                        }
                    },
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Id = 1,
                            DishType = new DishType
                            {
                                Id =1,
                                Name = "TestDishTypeName1",
                                DateCreated = DateTime.Now
                            },
                            DateCreated = DateTime.Now,
                            Name = "TestDishName1",
                            Price = 25.50M,
                            DishTypeId = 1
                        }
                    }
                },
                new Restaurant
                {
                    Id = 1,
                    Name = "TestRestaurant2",
                    City = "TestCity2",
                    Description = "TestDescription2",
                    Street = "TestStreet2",
                    Province = "TestProvince2",
                    HouseNumber = "2",
                    PostalCode = "00-002",
                    DateCreated = DateTime.Now,
                    RestaurantRatings = new List<RestaurantRating>
                    {
                        new RestaurantRating
                        {
                            RestaurantId = 2,
                            UserId = 1,
                            DateCreated = DateTime.Now,
                            Rating = 2
                        },
                        new RestaurantRating
                        {
                            RestaurantId = 2,
                            UserId = 2,
                            DateCreated = DateTime.Now,
                            Rating = 1
                        },
                        new RestaurantRating
                        {
                            RestaurantId = 2,
                            UserId = 3,
                            DateCreated = DateTime.Now,
                            Rating = 2
                        }
                    },
                    CuisinesTypes = new List<CuisineType>
                    {
                        new CuisineType
                        {
                            Id = 1,
                            DateCreated = DateTime.Now,
                            Name = "Type1"
                        },
                        new CuisineType
                        {
                            Id = 2,
                            DateCreated = DateTime.Now,
                            Name = "Type2"
                        }
                    },
                    Managers = new List<Manager>
                    {
                        new Manager
                        {
                            Id = 1,
                            DateCreated = DateTime.Now,
                            UserId = 4
                        }
                    },
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Id = 1,
                            DishType = new DishType
                            {
                                Id =1,
                                Name = "TestDishTypeName1",
                                DateCreated = DateTime.Now
                            },
                            DateCreated = DateTime.Now,
                            Name = "TestDishName1",
                            Price = 25.50M,
                            DishTypeId = 1
                        }
                    }
                },

            };

            var listOfRestaurantIds = new List<int>();


            var mockRepo = new Mock<IRestaurantRepository>();
            mockRepo.Setup(m => m.GetAll()).ReturnsAsync(restaurants);
            //mockRepo.Setup(m => m.Exists(It.IsIn<>)).ReturnsAsync(true);
            mockRepo.Setup(m => m.Exists(It.IsIn(1))).ReturnsAsync(true);
            

            mockRepo.Setup(m => m.Add(It.IsAny<Restaurant>())).ReturnsAsync((Restaurant restaurant) =>
            {
                restaurants.Add(restaurant);
                return restaurant;
            });

            return mockRepo;
        }
    }
}

