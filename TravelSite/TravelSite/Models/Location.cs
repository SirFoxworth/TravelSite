using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelSite.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}
