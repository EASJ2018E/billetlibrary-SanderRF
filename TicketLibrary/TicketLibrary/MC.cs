using System;

namespace TicketLibrary
{
    public class MC : Vehicles
    {
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// The Method is a string returning MC
        /// </summary>
        /// <returns></returns>
        public override string Vehicle()
        {
            return "MC";
        }
    }
}
