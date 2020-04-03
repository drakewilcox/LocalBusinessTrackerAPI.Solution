using Microsoft.EntityFrameworkCore;

namespace LocalBusinessTrackerAPI.Models
{
    public class LocalBusinessTrackerAPIContext : DbContext
    {
        public LocalBusinessTrackerAPIContext(DbContextOptions<LocalBusinessTrackerAPIContext> options)
            : base(options)
        {
        }
        public DbSet<Location> Locations { get; set; }
     
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Location>()
              .HasData(
              new Location { LocationId = 1, Name = "Pollo Bravo", Type = "Restaurant", Description = "Spanish Style Rotissere Chicken, Specialty Cocktails and Tapas", Rating = 5, Phone = "503.477.8899", Address = "126 SW 2nd Ave", Hours = "Everyday 11AM to 10PM", Website = "http://www.pollobravopdx.com/"},
              new Location { LocationId = 2, Name = "Billy Rays Neighborhood Dive", Type = "Bar", Description = "A Springboard for Bad Decisions", Rating = 4, Phone = "503.287.7254", Address = "2216 NE MLK Blvd", Hours = "Everyday NOON to 2AM", Website = "none"},

              new Location { LocationId = 3, Name = "Tienda Santa Cruz", Type = "Restaurant", Description = "Taqueria, Bakery and Grocery Store in St. Johns", Rating = 4, Phone = "503.286.7302", Address = "8630 N Lombard St.", Hours = "Everyday 11AM to 10PM", Website = "none"},

              new Location { LocationId = 4, Name = "Rum Club", Type = "Bar", Description = "Specialty Cocktail Lounge", Rating = 5, Phone = "503.265.8807", Address = "720 SE Sandy Blvd", Hours = "Everyday 4 to 2AM", Website = "rumclubpdx.com"},

              new Location { LocationId = 5, Name = "Mississippi Records", Type = "Retail", Description = "Small Independent Record Store and Label", Rating = 5, Phone = "503.282.2990", Address = "5202 N Albina Ave", Hours = "Everyday 12PM to 7PM", Website = "none"},

              new Location { LocationId = 6, Name = "Zero Wave", Type = "Retail", Description = "Used, Vintage, & Consignment Store", Rating = 4, Phone = "971.266.3492", Address = "720 N Killingsworth  St.", Hours = "THU - TUE 11AM - 6PM", Website = "none"} 
            );
       

        }
    }
}