using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LocalBusinessTrackerAPI.Models
{
  public class LocalBusinessTrackerApiContextFactory : IDesignTimeDbContextFactory<LocalBusinessTrackerAPIContext>
  {
    LocalBusinessTrackerAPIContext IDesignTimeDbContextFactory<LocalBusinessTrackerAPIContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<LocalBusinessTrackerAPIContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new LocalBusinessTrackerAPIContext(builder.Options);
    }
  }
}