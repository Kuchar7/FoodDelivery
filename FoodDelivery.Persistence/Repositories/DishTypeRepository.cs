using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Repositories
{
    public class DishTypeRepository : GenericRepository<DishType>, IDishTypeRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public DishTypeRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
