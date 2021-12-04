using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasIndex(d => d.Name).IsUnique();

            //builder.HasOne(d => d.DishType)
            //    .WithMany(t => t.Dishes)
            //    .HasForeignKey(d => d.DishTypeId)
            //    .IsRequired();

            //builder.HasOne(d => d.Restaurant)
            //    .WithMany(r => r.Dishes)
            //    .HasForeignKey(d => d.RestaurantId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);


            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(d => d.Price)
                .IsRequired()
                .HasPrecision(9, 2);

        }
    }
}
