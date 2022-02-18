using System;
using System.Collections.Generic;
using System.Text;

namespace TARC_BusRouteReader_BusRouteClass
{
    public class BusRoute
    {
        public int Number { get; }
        public string Origin { get; }
        public string Destination { get; }
        public BusRoute(int number, string origin, string destination)
        {
            this.Destination = destination;
            this.Number = number;
            this.Origin = origin;
        }
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";
    }
}
