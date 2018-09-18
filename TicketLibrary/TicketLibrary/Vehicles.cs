using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicles
    {
        private string Numberplate { get; set; }

        private DateTime Date { get; set; }

        public abstract double Price();

        public abstract string Vehicle();

        public abstract double DiscountPrice();
    }
}
