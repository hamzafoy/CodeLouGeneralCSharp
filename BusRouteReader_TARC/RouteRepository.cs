using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARC_BusRouteReader_BusRouteClass;

namespace TARC_BusRouteReader_RouteRepository
{
    public class BusDepot
    {
        public static BusRoute[] tarcRoutes =
            {
                new BusRoute(17, stops: new string[] {"N 8th St", "Liberty St", "Grinstead Dr", "Douglass Blvd", "Bashford Manor Ln", "S Hurstbourne Pkwy", "Glenmary Farms"}),
                new BusRoute(29, stops: new string[] {"Cane Run Rd", "7th Street Rd", "Taylor Blvd", "Winkler Ave", "Eastern Pkwy", "Bardstown Rd", "Shelbyville Rd", "Oxmoor Center"}),
                new BusRoute(25, stops: new string[] {"Shawnee Park", "Cecil Ave", "NIA Center", "Dumesnil St", "Oak St", "Grinstead Dr", "Shelbyville Rd", "Westport Rd", "N Hurstbourne Pkwy", "Springhurst Blvd"}),
                new BusRoute(63, stops: new string[] {"Terry Rd", "Greenwood Rd", "Greenbelt Hwy", "Cane Run Rd", "Crums Ln", "7th Street Rd", "S 7th St", "S 5th St", "N 4th St"})
            };

    }
}