using System;
using System.Collections.Generic;
using TARC_BusRouteReader_BusRouteClass;
using TARC_BusRouteReader_RouteRepository;

namespace TARC_BusRouteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What location would you like to search to see if there is a bus route?");
            string location = Console.ReadLine();
            BusRoute search = FindBusTo(BusDepot.tarcRoutes, location);
            Console.WriteLine((search == null) ? $"{location} has no bus route." : $"{search}");
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