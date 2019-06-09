using Aiport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aiport.Data.Context
{
    public static class AirportSeedingClass
    {
        public static void SeedFlightData(this ModelBuilder builder)
        {
            builder.Entity<Flight>().HasData(
                new Flight[]
                { 
                new Flight { Id = 101, Name = "British Airways", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 201, Name = "Lofthanza", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 301, Name = "Sosoliso", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 401, Name = "Ethiopian Air", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 501, Name = "Air France", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 601, Name = "Emirates", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Flight { Id = 701, Name = "Nigerian Airways", DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                });               
        }

        public static void SeedRouteData(this ModelBuilder builder)
        {
            builder.Entity<Route>().HasData(
                new Route[]
                {
                new Route { Id = 111, Name = "Lagos Abuja", CategoryId = 001, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                new Route { Id = 222, Name = "Lagos Enugu", CategoryId = 001, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 333, Name = "Lagos Acra", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 444, Name = "Lagos Johanesburg", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 555, Name = "Lagos London", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 666, Name = "Lagos Paris", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 777, Name = "Lagos Adis Ababa", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Route { Id = 888, Name = "Lagos Dubai", CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now }
                });
        }

        public static void SeedCategoryData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category[]
                {
                new Category { Id = 001, Name = "Local", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new Category { Id = 002, Name = "International", DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                });
        }

        public static void SeedFlightCategoryData(this ModelBuilder builder)
        {
            builder.Entity<FlightCategory>().HasData(
                new FlightCategory[]
                {
                new FlightCategory { Id = 20, FlightId = 101, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 21, FlightId = 201, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 22, FlightId = 301, CategoryId = 001, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 23, FlightId = 301, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 24, FlightId = 401, CategoryId = 001, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 25, FlightId = 401, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 26, FlightId = 501, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 27, FlightId = 601, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 28, FlightId = 701, CategoryId = 001, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightCategory { Id = 29, FlightId = 701, CategoryId = 002, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                });
        }

        public static void SeedFlightRouteData(this ModelBuilder builder)
        {
            builder.Entity<FlightRoute>().HasData(
                new FlightRoute[]
                {
                new FlightRoute { Id = 001, FlightId = 101, RouteId = 555,DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 002, FlightId = 201, RouteId = 444, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 003, FlightId = 301, RouteId = 111, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 004, FlightId = 301, RouteId = 222, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 005, FlightId = 301, RouteId = 333, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 006, FlightId = 401, RouteId = 111, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 007, FlightId = 401, RouteId = 222, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 008, FlightId = 401, RouteId = 777, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 009, FlightId = 501, RouteId = 666, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 010, FlightId = 601, RouteId = 888, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 011, FlightId = 701, RouteId = 111, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 012, FlightId = 701, RouteId = 111, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 013, FlightId = 701, RouteId = 333, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                new FlightRoute { Id = 014, FlightId = 701, RouteId = 555, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
                });
        }
    }
}
                 
