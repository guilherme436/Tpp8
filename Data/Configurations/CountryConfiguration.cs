using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tp11.Models;

namespace Tp11.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryName)
                   .HasMaxLength(100)
                   .HasColumnName("CountryName");

            builder.Property(c => c.CountryCode)
                   .HasMaxLength(10)
                   .HasColumnName("CountryCode");

            builder.HasData(
                new Country { Id = 1, CountryCode = "BR", CountryName = "Brasil" },
                new Country { Id = 2, CountryCode = "PT", CountryName = "Portugal" },
                new Country { Id = 3, CountryCode = "FR", CountryName = "França" }
            );
        }
