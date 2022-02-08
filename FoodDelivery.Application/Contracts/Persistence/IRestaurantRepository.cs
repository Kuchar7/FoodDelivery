using FoodDelivery.Application.DTOs.Restaurant;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Contracts.Persistence
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        
        Task<List<Restaurant>> GetRestaurantWithDetails();
        Task<Restaurant> GetRestaurantWithDetails(int id);
    }
}
