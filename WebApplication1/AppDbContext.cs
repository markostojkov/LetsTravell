using ConsoleApp1.Configs;
using ConsoleApp1.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationComment> LocationComments { get; set; }
        public DbSet<LocationEvent> LocationEvents { get; set; }
        public DbSet<LocationEventGoing> LocationEventGoings { get; set; }
        public DbSet<LocationEventOrganizer> LocationEventOrganizers { get; set; }
        public DbSet<LocationEventReview> LocationEventReviews { get; set; }
        public DbSet<LocationFavourite> LocationFavourites { get; set; }
        public DbSet<LocationPicture> LocationPictures { get; set; }
        public DbSet<LocationReview> LocationReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            const string schema = "dbo";

            builder.ApplyConfiguration(new FriendConfig(schema));
            builder.ApplyConfiguration(new LocationCommentConfig(schema));
            builder.ApplyConfiguration(new LocationConfig(schema));
            builder.ApplyConfiguration(new LocationEventConfig(schema));
            builder.ApplyConfiguration(new LocationEventGoingConfig(schema));
            builder.ApplyConfiguration(new LocationEventOrganizerConfig(schema));
            builder.ApplyConfiguration(new LocationEventReviewConfig(schema));
            builder.ApplyConfiguration(new LocationFavouriteConfig(schema));
            builder.ApplyConfiguration(new LocationPictureConfig(schema));
            builder.ApplyConfiguration(new LocationReviewConfig(schema));
        }
    }
}
