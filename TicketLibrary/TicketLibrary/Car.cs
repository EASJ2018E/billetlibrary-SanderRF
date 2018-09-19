using System;

namespace TicketLibrary
{
    public class Car : Vehicles
    {
        public override double Price()
        {
            return 240;
        }

        public override string Vehicle()
        {
            return "Bil";
        }
    }
}
