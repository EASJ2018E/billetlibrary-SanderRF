using System;

namespace TicketLibrary
{
    public class MC : Vehicles
    {
        public override double Price()
        {
            return 125;
        }

        public override string Vehicle()
        {
            return "MC";
        }
    }
}
