using System;
using System.Collections.Generic;
using TARC_BusRouteReader_BusRouteClass;

namespace TARC_BusRouteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route17 = new BusRoute(17, "8th Street", "Michael Edwards Dr");
            BusRoute route29 = new BusRoute(29, "Cane Run Rd", "Oxmoor Center");
            BusRoute route25 = new BusRoute(25, "Shawnee Park", "Accomack Dr");

            BusRoute[] routes =
            {
                route17, route29, route25, new BusRoute(63, "Terry Rd", "4th St")
            };

            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }
        }
    }
}