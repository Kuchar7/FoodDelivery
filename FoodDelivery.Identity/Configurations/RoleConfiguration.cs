using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "05ca92ec-eb4d-482e-bf04-f36db5228a98",
                    Name = "User",
                    NormalizedName = "USER"  
                },
                new IdentityRole
                {
                    Id = "473efbef-7318-4013-87ae-3018642dd4dc",
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                }
            );
        }
    }
}
