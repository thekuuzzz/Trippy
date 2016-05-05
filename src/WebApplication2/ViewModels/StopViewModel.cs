using Microsoft.AspNet.Authorization;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels
{
    [Authorize]
    public class StopViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "required")]
        [MinLength(5)]
        [MaxLength(255)]
        public string Name { get; set; }
        //TODO Current Time
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
