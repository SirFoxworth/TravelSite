using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using TravelSite;

namespace TravelSite.Models
{
    public class TravelSiteContextFactory : IDbContextFactory<TravelSiteContext>
    {
        public TravelSiteContext Create(string[] args) =>
            Program.BuildWebHost(args).Services.GetRequiredService<TravelSiteContext>();
    }
}