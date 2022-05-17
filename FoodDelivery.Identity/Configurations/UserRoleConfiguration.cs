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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "05ca92ec-eb4d-482e-bf04-f36db5228a98",
                        UserId = "9fdbc40e-7966-4298-a671-47ba7b2af0e6"
                    },

                    new IdentityUserRole<string>
                    {
                        RoleId = "473efbef-7318-4013-87ae-3018642dd4dc",
                        UserId = "9b212c62-5346-4cd8-bc14-ee111924d434"
                    }
                );
        }
    }
}
