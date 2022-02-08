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
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(40);

            #region SeedData


            builder.HasData(
                new CuisineType
                {
                    Id = 1,
                    Name = "Polish",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 2,
                    Name = "Indian",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 3,
                    Name = "Italian",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 4,
                    Name = "Thai",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 5,
                    Name = "Turkish",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 6,
                    Name = "Georgian",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 7,
                    Name = "Czech",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 8,
                    Name = "French",
                    DateCreated = DateTime.MinValue
                },
                new CuisineType
                {
                    Id = 9,
                    Name = "Mexican",
                    DateCreated = DateTime.MinValue
                }

                );
            #endregion

        }
    }
}
