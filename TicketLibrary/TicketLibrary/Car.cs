using System;

namespace TicketLibrary
{
    public class Car
    {
        public string Numberplate { get; set; }

        public DateTime Date { get; set; }

        /// <summary>
        /// The Method is a double returning 240
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// The Method is a string returning Bil
        /// </summary>
        /// <returns></returns>
        public string Vehicle()
        {
            return "Bil";
        }
    }
}
