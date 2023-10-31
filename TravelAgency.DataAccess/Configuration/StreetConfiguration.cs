using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelAgency.Models;

namespace TravelAgency.DataAccess.Configuration
{
    public class StreetConfiguration : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.HasKey(x => x.Guid);
            builder.Property(x => x.Name).IsRequired().HasDefaultValue(string.Empty);         
        }
    }
}
