using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelAgency.Models;

namespace TravelAgency.DataAccess.Configuration
{
    public class GeneralAdminConfiguration : IEntityTypeConfiguration<GeneralAdmin>
    {
        public void Configure(EntityTypeBuilder<GeneralAdmin> builder)
        {
            builder.HasKey(x => x.Guid);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(25);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Property(x => x.CreationDate).IsRequired();
            //builder.Property(x => x.Street).IsRequired().HasDefaultValue(new Street());
            builder.HasOne<Street>(x => x.Street)
                .WithMany(s => s.GeneralAdmins);
        }
    }
}
