using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The Ticket class
    /// </summary>
    public class Ticket
    {
        private bool insurance;

        public bool Insurance
        {
            get { return insurance; }
            set { insurance = value; }
        }
        private double totalCost;

        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        private double insuranceCost;

        public double InsuranceCost
        {
            get { return insuranceCost; }
            set { insuranceCost = value; }
        }
        private int passangersNumber;

        public int PassangersNumber
        {
            get { return passangersNumber; }
            set { passangersNumber = value; }
        }
        private bool roundTrip;

        public bool RoundTrip
        {
            get { return roundTrip; }
            set { roundTrip = value; }
        }
        private TicketType type;

        public TicketType Type
        {
            get { return type; }
            set { type = value; }
        }
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private SeatAssociation seat;

        public SeatAssociation Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        public void UpgradeType()
        {
           
        }

        public void ChangeSeat()
        {
            
        }

        public void ViewTicket()
        {
           
        }

        public void Purchase()
        {
            
        }

        public void Reserve()
        {
            
        }

        public void SearchTicket(string ticketNumber)
        {
            
        }
    }
}
