using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class LocationReview : Review
    {
        public long LocationFk { get; set; }

        public bool? Exists { get; set; }

        // NAVIGATION
        public Location Location { get; set; }
    }
}
