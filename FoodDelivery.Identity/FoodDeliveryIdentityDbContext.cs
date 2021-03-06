using FoodDelivery.Identity.Configurations;
using FoodDelivery.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Identity
{
    public class FoodDeliveryIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public FoodDeliveryIdentityDbContext(DbContextOptions<FoodDeliveryIdentityDbContext> options)
            : base(options)

        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
