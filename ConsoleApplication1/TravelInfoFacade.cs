using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// The TravelInfoFacade class. Get info to display or print ticket
    /// </summary>
    class TravelInfoFacade
    {
        private Flight _flight;
        private Seat _seat;
        private Ticket _ticket;
        private Route _route;

        /// <summary>
        /// Initialize subsystems
        /// </summary>
        public TravelInfoFacade()
        {
            _flight = new Flight();
            _seat = new Seat();
            _ticket = new Ticket();
        }

        public Flight Flight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Route Route
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Seat Seat
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Ticket Ticket
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Get flight number
        /// </summary>
        public String GetFlightNumber()
        {
            return _flight.Number;
        }

        /// <summary>
        /// Get seat number
        /// </summary>
        public int GetSeatNumber()
        {
            return _seat.Number;
        }

        /// <summary>
        /// Get ticket cost
        /// </summary>
        public double GetTicketCost()
        {
            return _ticket.TotalCost;
        }

        /// <summary>
        /// Get from location
        /// </summary>
        public String GetFrom()
        {
            return _route.From.ToString();
        }

        /// <summary>
        /// Get to location
        /// </summary>
        public String GetTo()
        {
            return _route.To.ToString();
        }

        /// <summary>
        /// Get departure time
        /// </summary>
        public String GetDepartureTime()
        {
            return _flight.DepartureTime.ToString();
        }

        /// <summary>
        /// Get arrival time
        /// </summary>
        public String GetArrivalTime()
        {
            return _flight.ArrivalTime.ToString();
        }
    }
}
