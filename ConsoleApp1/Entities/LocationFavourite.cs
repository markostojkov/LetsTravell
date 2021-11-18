namespace ConsoleApp1.Entities
{
    public class LocationFavourite : BaseEntity
    {
        public long UserFk { get; set; }

        public long LocationFk { get; set; }

        public ApplicationUser User { get; set; }

        public Location Location { get; set; }
    }
}
