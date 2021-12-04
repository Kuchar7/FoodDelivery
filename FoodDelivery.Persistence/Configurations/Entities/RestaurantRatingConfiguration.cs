using FoodDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Persistence.Configurations.Entities
{
    public class RestaurantRatingConfiguration : IEntityTypeConfiguration<RestaurantRating>
    {
        public void Configure(EntityTypeBuilder<RestaurantRating> builder)
        {
            builder.Property(r => r.Rating)
                .IsRequired();

        }
    }
}
