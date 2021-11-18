using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class LocationFavouriteConfig : BaseConfig<LocationFavourite>
    {
        public LocationFavouriteConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<LocationFavourite> builder)
        {
            base.Configure(builder);

            builder.ToTable("LocationFavourite", Schema);

            builder.Property(x => x.UserFk).HasColumnName(@"UserFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.LocationFk).HasColumnName(@"LocationFk").HasColumnType("bigint").IsRequired();

            builder.HasOne(x => x.User).WithMany(y => y.FavouriteLocations).HasForeignKey(x => x.UserFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Location).WithMany().HasForeignKey(x => x.LocationFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
