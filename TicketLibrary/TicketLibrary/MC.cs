using System;

namespace TicketLibrary
{
    public class MC : Vehicles
    {
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

        public override double DiscountPrice()
        {
            return Price() * 0.95;
        }
    }
}
