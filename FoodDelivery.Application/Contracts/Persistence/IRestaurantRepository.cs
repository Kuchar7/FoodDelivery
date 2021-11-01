using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Contracts.Persistence
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Task<bool> Exists(int Id);
    }
}
