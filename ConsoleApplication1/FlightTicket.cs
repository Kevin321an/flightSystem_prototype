﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The 'ConcreteAirLinePrice' class that implement the AirLinePrice
    /// </summary>
    class FlightTicket : AirLinePrice
    {
        /// <summary>
        /// inherent the constructor from  AirLinePrice class
        /// </summary>
        /// <param name="flight"></param>
        /// <param name="price"></param>
        public FlightTicket(string flight, double price)
          : base(flight, price)
        {
        }

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
        /// <summary>
        /// view flight history
        /// </summary>
        /// <param name="flight"></param>
        public void ViewFlightHistory(Flight flight)
        {
            
        }
        /// <summary>
        /// view schedule of the flight
        /// </summary>
        /// <param name="flight"></param>
        public void ViewSchedule(Flight flight)
        {
            
        }
        /// <summary>
        /// search flight
        /// </summary>
        /// <returns></returns>
        public FlightTicket Search()
        {
            return this;
        }
    }
}
