using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class OrderDishConfiguration : IEntityTypeConfiguration<OrderDish>
    {
        public void Configure(EntityTypeBuilder<OrderDish> builder)
        {
            //builder.HasOne(o => o.Order)
            //   .WithMany(r => r.OrderDishes)
            //   .HasForeignKey(o => o.OrderId);

            //builder.HasOne(o => o.Dish)
            //   .WithMany(d => d.OrderDishes)
            //   .HasForeignKey(o => o.DishId);
            builder.HasKey(x => x.Id);
            builder.Property(o => o.Quantity).IsRequired();

        }
    }
}
