using ConsoleApp1.Enums;

namespace ConsoleApp1.Entities
{
    public class LocationEventGoing : BaseEntity
    {
        public long UserFk { get; set; }

        public long LocationEventFk { get; set; }

        public GoingStatus Status { get; set; }

        public ApplicationUser User { get; set; }

        public LocationEvent LocationEvent { get; set; }
    }
}
