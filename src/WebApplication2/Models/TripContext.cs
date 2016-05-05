using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace WebApplication2.Models
{
    public class TripContext : IdentityDbContext<AppUser>
    {
        public TripContext()
        {
            Database.EnsureCreated();

        }
        public DbSet<Trip> Trips { get; set; }

        public DbSet<Stop> Stops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString =
               Startup.Configuration["Data:DefaultConnection:TripsConnectionString"];
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }


    }

}
