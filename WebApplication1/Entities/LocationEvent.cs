using System;
using System.Collections.Generic;

namespace ConsoleApp1.Entities
{
    public class LocationEvent : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public long CreatorFk { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime StartsOn { get; set; }

        public long LocationFk { get; set; }

        public bool IsPrivate { get; set; }

        // NAVIGATION
        public ApplicationUser ApplicationUser { get; set; }

        public Location Location { get; set; }

        public ICollection<LocationEventOrganizer> Organizers { get; set; }

        public ICollection<LocationEventGoing> UsersGoing { get; set; }

        public ICollection<LocationEventReview> Reviews { get; set; }
    }
}
