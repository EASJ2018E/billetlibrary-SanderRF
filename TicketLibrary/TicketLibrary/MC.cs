using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC
    {
        public string Numberplate { get; set; }

        public DateTime Date { get; set; }

        /// <summary>
        /// The Method is a double returning 125
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// The Method is a string returning MC
        /// </summary>
        /// <returns></returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
