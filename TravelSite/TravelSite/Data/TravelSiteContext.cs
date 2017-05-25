using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelSite.Models
{
    public class TravelSiteContext : DbContext
    {
        public TravelSiteContext (DbContextOptions<TravelSiteContext> options)
            : base(options)
        {
        }

        public DbSet<TravelSite.Models.Trip> Trip { get; set; }
    }
}
