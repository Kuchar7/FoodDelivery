using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Contracts.Persistence
{
    public interface IDishTypeRepository : IGenericRepository<Dish>
    {
    }
}
