using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalBusinessTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private LocalBusinessTrackerAPIContext _db; 
        public LocationsController(LocalBusinessTrackerAPIContext db)
        {
          _db = db;
        }

        // GET api/locations
        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get(string name, string type)
        {
           var query = _db.Locations.AsQueryable();
           if (name != null)
           {
               query = query.Where(location => location.Name == name);
           }
           if (type != null)
           {
               query = query.Where(location => location.Type == type);
           }
           return query.ToList();
        }

        // GET api/locations/5
        [HttpGet("{id}")]
        public ActionResult<Location> Get(int id)
        {
            return _db.Locations.FirstOrDefault(loc => loc.LocationId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Location location)
        {
            _db.Locations.Add(location);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Location location)
        {
          location.LocationId = id; 
          _db.Entry(location).State = EntityState.Modified; 
          _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         var locationToDelete = _db.Locations.FirstOrDefault(loc => loc.LocationId == id);
          _db.Locations.Remove(locationToDelete);
          _db.SaveChanges(); 
        }
    }
}
