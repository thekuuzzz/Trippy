using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AutoMapper;
using WebApplication2.Models;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.ViewModels
{
    [Authorize]
    [Route("api/[controller]/{stopName}")]
    public class StopsController : Controller
    {
        private Models.TripContext db = new Models.TripContext();
        private Models.TripRepository tr = new Models.TripRepository();
        private Services.CoordinateService cr = new Services.CoordinateService();
        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var rips = tr.GetAllTrips();
            var results = Mapper.Map<IEnumerable<TripViewModel>>(rips);
            var trips = Json(results);

            return trips;
            
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public Stop Get(Stop s)
        {
            return tr.GetStoppy(s);
        }

        // POST api/values
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Post(TripViewModel t)
        {
            if (ModelState.IsValid)
            {
                var oppy = t;
                var newStop = Mapper.Map<Stop>(oppy);
                var longlat = await cr.Lookup(newStop.Name);
                var trips = Json(newStop);
         
                return trips;
            }
            else
            {
                return null;
            }


        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
