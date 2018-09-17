using System;

namespace TicketLibrary
{
    public class Car : Vehicles
    {
        //public string Numberplate { get; set; }

        //public DateTime Date { get; set; }

        /// <summary>
        /// The Method is a double returning 240
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// The Method is a string returning Bil
        /// </summary>
        /// <returns></returns>
        public override string Vehicle()
        {
            return "Bil";
        }
    }
}
