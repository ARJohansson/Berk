using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public interface ILocationRepository
    {
        List<Location> Locations { get; }
        void AddLocation(Location place);
        void AddLocationData();
        Location GetLocationByName(String name);

    }
}
