using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Repositories
{
    public class CuisineTypeRepository : GenericRepository<CuisineType>, ICuisineTypeRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public CuisineTypeRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
