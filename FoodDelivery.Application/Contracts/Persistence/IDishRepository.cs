using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Contracts.Persistence
{
    public interface IDishRepository : IGenericRepository<Dish>
    {
        Task<List<Dish>> GetDishes(int id);
        Task<Dish> GetSpecificDish(int restaurantId, int dishId);
    }
}
