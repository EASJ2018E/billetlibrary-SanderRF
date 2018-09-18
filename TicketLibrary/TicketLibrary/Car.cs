﻿using System;

namespace TicketLibrary
{
    public class Car : Vehicles
    {
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

        public override double DiscountPrice()
        {
            return Price() * 0.95;
        }
    }
}
