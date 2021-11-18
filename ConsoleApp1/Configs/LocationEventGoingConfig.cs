using ConsoleApp1.Entities;
using ConsoleApp1.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConsoleApp1.Configs
{
    public class LocationEventGoingConfig : BaseConfig<LocationEventGoing>
    {
        public LocationEventGoingConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationEventGoing> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationEventGoing", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LocationEventFk).HasColumnName(@"LocationEventFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired().HasDefaultValue(GoingStatus.Invited);

            builder.HasOne(x => x.User).WithMany(y => y.GoingToEvents).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.LocationEvent).WithMany(y => y.UsersGoing).HasForeignKey(x => x.LocationEvent).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
