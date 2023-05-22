using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShuttleServiceManagement.Domain.Entities;
using ShuttleServiceManagement.Domain.ValueObjects;
using ShuttleServiceManagement.Persistence.Constants;

namespace ShuttleServiceManagement.Persistence.Configurations
{
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.ToTable(TableNames.Buses);

            builder.HasKey(b => b.Id);

            builder.Property(b => b.DriverName)
                .HasMaxLength(DriverName.MaxLength)
                .HasConversion(x => x.Value, v => DriverName.Create(v).Value);
        }
    }
}
