using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class SeatAssociation
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private FlightTicket flight;

        private FlightTicket Flight
        {
            get { return flight; }
            set { flight = value; }
        }
        private Aircraft aircraft;

        public Aircraft Aircraft
        {
            get { return aircraft; }
            set { aircraft = value; }
        }
        private Seat seat;

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }
    }
}
