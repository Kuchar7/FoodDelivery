using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class CuisineTypeConfiguration : IEntityTypeConfiguration<CuisineType>
    {
        public void Configure(EntityTypeBuilder<CuisineType> builder)
        {
            builder.HasData(
                new CuisineType
                {
                    Id = 1,
                    Name = "Polish",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 2,
                    Name = "Indian",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 3,
                    Name = "Italian",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 4,
                    Name = "Thai",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 5,
                    Name = "Turkish",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 6,
                    Name = "Georgian",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 7,
                    Name = "Czech",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 8,
                    Name = "French",
                    DateCreated = DateTime.Now
                },
                new CuisineType
                {
                    Id = 9,
                    Name = "Mexican",
                    DateCreated = DateTime.Now
                }

                );
        }
    }
}
