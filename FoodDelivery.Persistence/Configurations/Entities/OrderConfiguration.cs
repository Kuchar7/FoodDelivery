using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //builder.HasOne(o => o.OrderStatus)
            //    .WithMany(s => s.Orders)
            //    .HasForeignKey(o => o.OrderStatusId);

            //builder.HasOne(o => o.DeliveryMan)
            //    .WithMany(d => d.Orders)
            //    .HasForeignKey(o => o.DeliveryManId);

            //builder.HasOne(o => o.User)
            //    .WithMany(u => u.Orders)
            //    .HasForeignKey(o => o.UserId);

            builder.Property(o => o.Note).HasMaxLength(250);

            builder.Property(o => o.OrderStatusId)
                .IsRequired()
                .HasDefaultValue(0);
        }
    }
}
