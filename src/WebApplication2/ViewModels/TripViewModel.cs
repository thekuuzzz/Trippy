using Microsoft.AspNet.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModels
{
    [Authorize]
    public class TripViewModel
    {
         
        public int ID { get; set; }
        [Required(ErrorMessage = "required")][MinLength(5)][MaxLength(255)]
        public string Name { get; set; }
        //TODO Current Time
        public DateTime DateCreated { get; set; }
        public ICollection<StopViewModel> Stops { get; set; }
    }
}
