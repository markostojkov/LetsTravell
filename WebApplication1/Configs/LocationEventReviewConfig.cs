using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class LocationEventReviewConfig : BaseConfig<LocationEventReview>
    {
        public LocationEventReviewConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationEventReview> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationEventReview", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Text).HasColumnName(@"Text").HasColumnType("nvarchar").IsRequired(false).HasMaxLength(4000);
            builder.Property(x => x.Rating).HasColumnName(@"Rating").HasColumnType("tinyint").IsRequired();
            builder.Property(x => x.EventFk).HasColumnName(@"EventFk").HasColumnType("bigint").IsRequired();

            builder.HasOne(x => x.ApplicationUser).WithMany(y => y.LocationEventReviews).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.LocationEvent).WithMany(y => y.Reviews).HasForeignKey(x => x.EventFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
