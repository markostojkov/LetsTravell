namespace ConsoleApp1.Entities
{
    public class LocationEventOrganizer : BaseEntity
    {
        public long UserFk { get; set; }

        public long LocationEventFk { get; set; }

        public ApplicationUser User { get; set; }

        public LocationEvent LocationEvent { get; set; }
    }
}
