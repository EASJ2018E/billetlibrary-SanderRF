using System;

namespace TicketLibrary
{
    public class Car : Vehicles
    {
        /// <summary>
        /// Retunerer prisen på en bil
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Retunerer typen af køretøj
        /// </summary>
        /// <returns></returns>
        public override string Vehicle()
        {
            return "Bil";
        }
    }
}
