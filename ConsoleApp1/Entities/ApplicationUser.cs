using ConsoleApp1.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ConsoleApp1.Entities
{
    public class ApplicationUser : IdentityUser<long>
    {
        public UserRole Role { get; set; }

        public string ImageUrl { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Navigation
        public ICollection<LocationEvent> CreatorEvents { get; set; }

        public ICollection<LocationEventOrganizer> OrganizerEvents { get; set; }
        
        public ICollection<Location> CreatedLocations { get; set; }
        
        public ICollection<LocationFavourite> FavouriteLocations { get; set; }
        
        public ICollection<LocationEventGoing> GoingToEvents { get; set; }
        
        public ICollection<LocationPicture> Pictures { get; set; }
        
        public ICollection<LocationReview> LocationReviews { get; set; }
        
        public ICollection<LocationEventReview> LocationEventReviews { get; set; }
        
        public ICollection<LocationComment> LocationComments { get; set; }
       
        public ICollection<Friend> Friends { get; set; }
    }
}
