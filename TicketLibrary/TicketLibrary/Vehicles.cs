using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicles
    {
        public string Numberplate { get; set; }

        public DateTime Date { get; set; }

        public abstract double Price();

        public abstract string Vehicle();
    }
}
