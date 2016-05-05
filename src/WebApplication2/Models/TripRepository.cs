using Microsoft.AspNet.Authorization;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.SqlServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    [Authorize]
    public class TripRepository : DbContext
    {
        private TripContext trips;

        public TripRepository()
        {
            
        }

        public TripRepository(TripContext rip)
        {
            trips = rip;
        }
        public IEnumerable GetAllTrips()
        {
            return trips.ToString();
        }

        public Trip GetTrippy(Trip t)
        {
            var rips = trips.Trips
                .Include(trips => trips.ID)
                .Include(trips => trips.DateCreated)
                .Include(trips => trips.Stops)
                .Where(trips => trips.Name == t.Name);
            return (Trip)rips;
        }
        public Stop GetStoppy(Stop s)
        {
            var ops = trips.Stops
                .Include(trips => trips.ID)
                .Include(trips => trips.Longitude)
                .Include(trips => trips.Latitude)
                .Include(trips => trips.ArrivalDate )
                .Where(trips => trips.Name == s.Name);
            return (Stop)ops;
        }
    }
}
