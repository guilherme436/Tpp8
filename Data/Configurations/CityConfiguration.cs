using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp11.Models;
using Tpp8.Data.models;

namespace Tp11.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name)
                   .HasMaxLength(100)
                   .HasColumnName("CityName");

            builder.HasData(
                new City { Id = 1, Name = "Rio de Janeiro", CountryId = 1 },
                new City { Id = 2, Name = "Lisboa", CountryId = 2 },
                new City { Id = 3, Name = "Paris", CountryId = 3 }
            );
        }