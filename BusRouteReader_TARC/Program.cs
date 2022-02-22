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
            Console.WriteLine("What road would you like to search to see if there is a bus route that serves it?");
            string location = Console.ReadLine();
            BusRoute[] search = FindBusesTo(BusDepot.tarcRoutes, location);
            if (search.Length == 0)
            {
                Console.WriteLine($"{location} has no TARC bus serving it at this time.");
            } else
            {
                foreach (BusRoute stop in search)
                    Console.WriteLine($"{stop}");
            }
        }

        public static BusRoute[] FindBusesTo(BusRoute[] routeList, string location)
        {
            //foreach (BusRoute route in routeList)
            //{
            //    if(route.Origin == location || route.Destination == location)
            //    {
            //        return route;
            //    }
            //}
            //return null;

            return Array.FindAll(BusDepot.tarcRoutes, route => route.Serves(location));
        }
    }
}