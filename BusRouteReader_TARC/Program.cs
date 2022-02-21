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

            BusRoute[] routes =
            {
                route17, route29
            };

            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }
        }
    }
}