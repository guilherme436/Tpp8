using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp11.Models;
using Tpp8.Data.models;

namespace Tp11.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(150)
                   .HasColumnName("PropertyName");

            builder.Property(p => p.PricePerNight)
                   .HasColumnName("PricePerNight");

            builder.HasData(
                new Property { Id = 1, Name = "Apartamento Copacabana", PricePerNight = 350.00m, CityId = 1 },
                new Property { Id = 2, Name = "Hotel Central Lisboa", PricePerNight = 500.00m, CityId = 2 },
                new Property { Id = 3, Name = "Studio Torre Eiffel", PricePerNight = 750.00m, CityId = 3 }
            );
        }