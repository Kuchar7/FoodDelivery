using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Persistence.Repositories
{
    public class DishRepository : GenericRepository<Dish>, IDishRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public DishRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Dish>> GetAllDishesByRestaurantId(int id)
        {
            return await _dbContext.Dishes.Where(d => d.RestaurantId == id).ToListAsync();
        }
    }
}
