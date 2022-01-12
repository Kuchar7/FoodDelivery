using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Persistence.Repositories
{
    public class CuisineTypeRepository : GenericRepository<CuisineType>, ICuisineTypeRepository
    {
        private readonly FoodDeliveryDbContext _dbContext;

        public CuisineTypeRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CuisineType>> GetCuisineTypesByIds(List<int> ids)
        {
            var cuisineTypes = new List<CuisineType>();
            foreach (var id in ids)
            {
                cuisineTypes.Add(await _dbContext.CuisineTypes.FindAsync(id));
            }
            return cuisineTypes;
        }
    }
}
