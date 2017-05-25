using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelSite.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public Location Location { get; set; }
        public List<Location> Route { get; set; }
    }
}
