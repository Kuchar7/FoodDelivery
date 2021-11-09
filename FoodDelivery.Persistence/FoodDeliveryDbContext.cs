using FoodDelivery.Domain.Common;
using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDelivery.Persistence
{
    public class FoodDeliveryDbContext : DbContext
    {
        public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FoodDeliveryDbContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                entry.Entity.LastDateModified = DateTime.Now;
                if (entry.State == EntityState.Added)
                    entry.Entity.DateCreated = DateTime.Now;

            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<CuisineType> CuisineTypes { get; set; }
    }
}
