using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            //builder.HasMany(o => o.Orders)
            //    .WithOne(r => r.OrderStatus)
            //    .HasForeignKey(r => r.OrderStatusId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.Name);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            #region SeedData
            builder.HasData(
            new OrderStatus
            {
                Id = 1,
                Name = "Placed"
            },
            new OrderStatus
            {
                Id = 2,
                Name = "Accepted"
            },
            new OrderStatus
            {
                Id = 3,
                Name = "Delivered"
            }
            );
            #endregion
        }
    }
}
