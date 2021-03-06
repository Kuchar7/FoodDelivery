using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Contracts.Persistence
{
    public interface ICuisineTypeRepository : IGenericRepository<CuisineType>
    {
        Task<List<CuisineType>> GetCuisineTypesByIds(List<int> ids);
    }
}
