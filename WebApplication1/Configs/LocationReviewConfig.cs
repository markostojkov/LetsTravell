using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class LocationReviewConfig : BaseConfig<LocationReview>
    {
        public LocationReviewConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationReview> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationReview", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Text).HasColumnName(@"Text").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(4000);
            builder.Property(x => x.Rating).HasColumnName(@"Rating").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.LocationFk).HasColumnName(@"LocationFk").HasColumnType("bigint").IsRequired();

            builder.HasOne(x => x.ApplicationUser).WithMany(y => y.LocationReviews).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Location).WithMany(y => y.LocationReviews).HasForeignKey(x => x.LocationFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
