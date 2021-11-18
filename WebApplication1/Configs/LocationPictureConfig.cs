using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp1.Configs
{
    public class LocationPictureConfig : BaseConfig<LocationPicture>
    {
        public LocationPictureConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationPicture> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationPicture", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Url).HasColumnName(@"Url").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            builder.Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("smalldatetime").IsRequired().HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            builder.Property(x => x.LocationFk).HasColumnName(@"LocationFk").HasColumnType("bigint").IsRequired();

            builder.HasOne(x => x.ApplicationUser).WithMany(y => y.Pictures).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Location).WithMany(y => y.LocationPictures).HasForeignKey(x => x.LocationFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
