using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CoordinatesResult
    {
        public double Latitude { get; internal set; }
        public double Longitude { get; internal set; }
        public string Message { get; internal set; }
        public bool Success { get; internal set; }
    }
}
