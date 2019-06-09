using Aiport.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiport.Data.Context
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext(DbContextOptions<AirportDbContext> options) : base(options)
        {
           //Database.Migrate();
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FlightRoute> FlightRoutes { get; set; }
        public DbSet<FlightCategory> FlightCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedFlightData();
            builder.SeedRouteData();
            builder.SeedCategoryData();
            builder.SeedFlightCategoryData();
            builder.SeedFlightRouteData();
        }
    }
}
