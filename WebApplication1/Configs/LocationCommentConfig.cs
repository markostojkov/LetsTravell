using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp1.Configs
{
    public class LocationCommentConfig : BaseConfig<LocationComment>
    {
        public LocationCommentConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationComment> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationComment", Schema);

            builder.Property(x => x.Text).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            builder.Property(x => x.LocationFk).HasColumnName(@"LocationFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("smalldatetime").IsRequired().HasDefaultValue(DateTime.UtcNow).HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            builder.HasOne(x => x.ApplicationUser).WithMany(y => y.LocationComments).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
