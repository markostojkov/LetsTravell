using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class LocationEventReview : Review
    {
        public long EventFk { get; set; }

        // NAVIGATION
        public LocationEvent LocationEvent { get; set; }
    }
}
