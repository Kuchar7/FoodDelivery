using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public RestaurantRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
