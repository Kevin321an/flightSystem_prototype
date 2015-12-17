using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class FlightTicket
    {
        private Flight flight;

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private Aircraft aircraft;

        public Aircraft Aircraft
        {
            get { return aircraft; }
            set { aircraft = value; }
        }
        private Ticket ticket;

        public Ticket Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }
        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public void ViewFlightHistory(Flight flight)
        {
            
        }

        public void ViewSchedule(Flight flight)
        {
            
        }

        public FlightTicket Search()
        {
            return this;
        }
    }
}
