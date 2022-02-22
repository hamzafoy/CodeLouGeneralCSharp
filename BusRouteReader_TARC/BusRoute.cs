using System;
using System.Collections.Generic;
using System.Text;

namespace TARC_BusRouteReader_BusRouteClass
{
    public class BusRoute
    {
        public int Number { get; }
        public string[] Stops { get; }
        public string Origin => Stops[0];
        public string Destination => Stops[Stops.Length - 1];
        public BusRoute(int number, string[] stops)
        {
            this.Number = number;
            this.Stops = stops;
        }
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";

        public bool Serves(string destination)
        {

            return Array.Exists(Stops, stop => stop == destination);
        }
    }
}
