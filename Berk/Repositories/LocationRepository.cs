using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;
using Microsoft.EntityFrameworkCore;

namespace Berk.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private AppDbContext context;
        private static List<Location> locations = new List<Location>();

        public List<Location> Locations { get { return context.Locations.Include("Comments").ToList(); } }
        
        public LocationRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddLocation(Location place)
        {
            context.Locations.Add(place);
            context.SaveChanges();
        }

        public Location GetLocationByName(String name)
        {
            Location location;
            location = context.Locations.First(l => l.Name == name);
            return location;
        }
        
    }
}
