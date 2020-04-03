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

        // GET api/values
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

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
