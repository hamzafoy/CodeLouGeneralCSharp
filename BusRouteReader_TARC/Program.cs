using System;
using System.Collections.Generic;
using TARC_BusRouteReader_BusRouteClass;

namespace TARC_BusRouteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] routes =
            {
                new BusRoute(17, "8th Street", "Michael Edwards Dr"), new BusRoute(29, "Cane Run Rd", "Oxmoor Center"), new BusRoute(25, "Shawnee Park", "Accomack Dr"), new BusRoute(63, "Terry Rd", "4th St")
            };

            Console.WriteLine("What location would you like to search to see if there is a bus route?");
            BusRoute search = FindBusTo(routes, Console.ReadLine());
            Console.WriteLine((search == null) ? $"That location has no bus route" : $"{search}");
        }

        public static BusRoute FindBusTo(BusRoute[] routeList, string location)
        {
            foreach (BusRoute route in routeList)
            {
                if(route.Origin == location || route.Destination == location)
                {
                    return route;
                }
            }
            return null;
        }
    }
}