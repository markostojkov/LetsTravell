using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class LocationComment : BaseEntity
    {
        public long UserFk { get; set; }

        public string Text { get; set; }

        public long LocationFk { get; set; }

        public DateTime CreatedOn { get; set; }

        // NAVIGATION
        public ApplicationUser ApplicationUser { get; set; }

        public Location Location { get; set; }
    }
}
