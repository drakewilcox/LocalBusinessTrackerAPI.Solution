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
     
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //   builder.Entity<Location>()
        //       .HasData(
              
        //     );
       

        }
    }
}