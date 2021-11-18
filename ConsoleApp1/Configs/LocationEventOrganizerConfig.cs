using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class LocationEventOrganizerConfig : BaseConfig<LocationEventOrganizer>
    {
        public LocationEventOrganizerConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationEventOrganizer> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationEventOrganizer", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LocationEventFk).HasColumnName(@"LocationEventFk").HasColumnType("bigint").IsRequired();

            builder.HasOne(x => x.User).WithMany(y => y.OrganizerEvents).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.LocationEvent).WithMany(y => y.Organizers).HasForeignKey(x => x.LocationEvent).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
