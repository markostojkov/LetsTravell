using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp1.Configs
{
    public class LocationEventConfig : BaseConfig<LocationEvent>
    {
        public LocationEventConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationEvent> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationEvent", Schema);

            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(4000);
            builder.Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            builder.Property(x => x.CreatorFk).HasColumnName(@"CreatorFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("smalldatetime").IsRequired().HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            builder.Property(x => x.StartsOn).HasColumnName(@"StartsOn").HasColumnType("smalldatetime").IsRequired().HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            builder.Property(x => x.LocationFk).HasColumnName(@"Longitude").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.IsPrivate).HasColumnName(@"IsPrivate").HasColumnType("bit").IsRequired().HasDefaultValue(false);

            builder.HasOne(x => x.ApplicationUser).WithMany(y => y.CreatorEvents).HasForeignKey(x => x.CreatorFk).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Location).WithMany(y => y.LocationEvents).HasForeignKey(x => x.LocationFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
