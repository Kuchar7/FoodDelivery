using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class DishTypeConfiguration : IEntityTypeConfiguration<DishType>
    {
        public void Configure(EntityTypeBuilder<DishType> builder)
        {

            //builder.HasIndex(x => x.Name).IsUnique();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
