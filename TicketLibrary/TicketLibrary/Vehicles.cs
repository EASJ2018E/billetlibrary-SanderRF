using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicles
    {
        public string LicenseNumber { get; set; }
        /// <summary>
        /// The Method is a double which returns price for a ticket
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// The Method is a string which returns what type of vehicle it is
        /// </summary>
        /// <returns></returns>
        public abstract string Vehicle();

        /// <summary>
        /// The method is a double which returns price with 5% discount
        /// </summary>
        /// <returns></returns>
        public virtual double DiscountPrice()
        {
            return Price() * 0.95;
        }

        public virtual string LicensePlate()
        {
            if (LicenseNumber.Length>7)
                throw new ArgumentException("The number plate cannot contain more than 7 characters");
            
                return LicenseNumber;

        }
    }
}
