using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Controllers;
using AutoMapper;
using WebApplication2.Models;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.ViewModels
{
    [Route("api/[controller]/{tripName}")]
    [Authorize]
    public class TripsController : Controller
    {
        private Models.TripContext db = new Models.TripContext();
        private Models.TripRepository tr = new Models.TripRepository();
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
        public Trip Get(Trip t)
        {
            return tr.GetTrippy(t);
        }

        // POST api/values
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Post(TripViewModel t)
        {
            if (ModelState.IsValid)
            {
                var rips = t;
                var newTrip = Mapper.Map<Trip>(rips);
                var trips = Json(newTrip);
         
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
