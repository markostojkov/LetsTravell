using System.Collections.Generic;

namespace ConsoleApp1.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string GeographicalLocation { get; set; }

        public string Note { get; set; }

        public long CreatorFk { get; set; }

        public string City { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public bool IsAccepted { get; set; }

        public decimal ReviewScore { get; set; }

        //NAVIGATIONS
        public ApplicationUser Creator { get; set; }

        public ICollection<LocationReview> LocationReviews { get; set; }

        public ICollection<LocationPicture> LocationPictures { get; set; }

        public ICollection<LocationComment> LocationComments { get; set; }

        public ICollection<LocationEvent> LocationEvents { get; set; }
    }
}
