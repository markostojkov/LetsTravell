using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class LocationConfig : BaseConfig<Location>
    {
        public LocationConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<Location> builder)
        {
            base.Configure(builder);

            builder.ToTable("Location", Schema);

            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(4000);
            builder.Property(x => x.GeographicalLocation).HasColumnName(@"GeographicalLocation").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            builder.Property(x => x.CreatorFk).HasColumnName(@"CreatorFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            builder.Property(x => x.Longitude).HasColumnName(@"Longitude").HasColumnType("decimal(20,10)").IsRequired();
            builder.Property(x => x.Latitude).HasColumnName(@"Latitude").HasColumnType("decimal(20,10)").IsRequired();
            builder.Property(x => x.IsAccepted).HasColumnName(@"IsAccepted").HasColumnType("bit").IsRequired().HasDefaultValue(false);
            builder.Property(x => x.ReviewScore).HasColumnName(@"ReviewScore").HasColumnType("decimal(9,2)").IsRequired().HasDefaultValue(0.0);

            builder.HasOne(x => x.Creator).WithMany(y => y.CreatedLocations).HasForeignKey(x => x.CreatorFk).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
