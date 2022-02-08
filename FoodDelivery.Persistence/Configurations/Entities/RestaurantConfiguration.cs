using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            //builder.HasMany(r => r.Dishes)
            //    .WithOne(d => d.Restaurant)
            //    .HasForeignKey(d => d.RestaurantId);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(r => r.Province)
                .IsRequired()
                .HasMaxLength(50);


            builder.Property(r => r.City).IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.PostalCode).IsRequired()
                .HasMaxLength(30);

            builder.Property(r => r.Street).IsRequired()
                .HasMaxLength(65);

            builder.Property(r => r.HouseNumber).IsRequired()
                .HasMaxLength(20);
            


        }
    }
}
