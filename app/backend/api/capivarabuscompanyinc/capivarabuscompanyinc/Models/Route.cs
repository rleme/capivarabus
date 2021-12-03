using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Route
    {
        public int RouteId { get; set; }

        public string RouteName { get; set; }

        public string RouteSource { get; set; }

        public string RouteTarget { get; set; }

        public string RouteDistance { get; set; }
        
    }
}
