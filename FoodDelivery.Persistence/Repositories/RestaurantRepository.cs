using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Persistence.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public RestaurantRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Restaurant>> GetRestaurantWithDetails()
        {
            return await _dbContext.Restaurants
                .Include(x => x.Dishes)
                .Include(x => x.CuisinesTypes)
                .ToListAsync();
        }

        public async Task<Restaurant> GetRestaurantWithDetails(int id)
        {
            return await _dbContext.Restaurants
                .Include(x => x.Dishes)
                .Include(x => x.CuisinesTypes)
                .FirstOrDefaultAsync(x => x.Id == id);
        }


    }
}
