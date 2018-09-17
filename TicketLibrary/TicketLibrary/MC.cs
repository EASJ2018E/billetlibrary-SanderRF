using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC : Vehicles
    {
        //public string Numberplate { get; set; }

        //public DateTime Date { get; set; }

        /// <summary>
        /// The Method is a double returning 125
        /// </summary>
        /// <returns></returns>
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
