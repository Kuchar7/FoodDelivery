using FoodDelivery.Identity.Models;
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
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData
                (
                    new ApplicationUser
                    {
                        Id = "9fdbc40e-7966-4298-a671-47ba7b2af0e6",
                        Email = "user@test.com",
                        NormalizedEmail = "USER@TEST.COM",
                        UserName = "user@test.com",
                        NormalizedUserName = "USER@TEST.COM",
                        FirstName = "TestFirstName",
                        LastName = "TestLastName",
                        Province = "mazowieckie",
                        City = "Warszawa",
                        PostalCode = "00-001",
                        Street = "Szczęśliwa",
                        HouseNumber = "23",
                        FlatNumber = "2",
                        FloorNumber = 2,
                        PhoneNumber = "123123123",
                        PasswordHash = hasher.HashPassword(null, "Pass12#"),
                        EmailConfirmed = true
                    },

                    new ApplicationUser
                    {
                        Id = "9b212c62-5346-4cd8-bc14-ee111924d434",
                        Email = "manager@test.com",
                        NormalizedEmail = "MANAGER@TEST.COM",
                        UserName = "manager@test.com",
                        NormalizedUserName = "MANAGER@TEST.COM",
                        FirstName = "TestFirstName",
                        LastName = "TestLastName",
                        Province = "mazowieckie",
                        City = "Warszawa",
                        PostalCode = "00-001",
                        Street = "Kolorowa",
                        HouseNumber = "2",
                        FlatNumber = "5",
                        FloorNumber = 3,
                        PhoneNumber = "123123121",
                        PasswordHash = hasher.HashPassword(null, "Pass12#"),
                        EmailConfirmed = true
                    }
                );
        }
    }
}
