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
                new BusRoute(17, "8th Street", "Michael Edwards Dr"),
                new BusRoute(29, "Cane Run Rd", "Oxmoor Center"),
                new BusRoute(25, "Shawnee Park", "Accomack Dr"),
                new BusRoute(63, "Terry Rd", "4th St")
            };

    }
}
