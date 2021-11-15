using FoodDelivery.Application.Contracts.Persistence;
using FoodDelivery.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration )
        {
            services.AddDbContext<FoodDeliveryDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("FoodDeliveryConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<ICuisineTypeRepository, CuisineTypeRepository>();

            return services;
        }
    }
}
