using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication2.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private TripContext db = new TripContext();
        private TripRepository tr = new TripRepository();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Trip = db.Trips.Include(a => a.ID).Include(a => a.Name);
            return View(Trip.ToList());
        
        }
        public IActionResult About()
        {
            var Trip = tr.GetAllTrips();
            return View();

        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Trip()
        {
            return ViewBag.Trip;
        }
    }
}
