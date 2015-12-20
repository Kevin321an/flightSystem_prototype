using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The Seat class
    /// </summary>
    public class Seat
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string row;

        public string Row
        {
            get { return row; }
            set { row = value; }
        }
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private bool availability;

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        /// <summary>
        /// aisle, window
        /// </summary>
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Seat()
        {
            
        }

        public void Update(Seat seat)
        {
           
        }

        public void Delete(Seat seat)
        {
           
        }

        public Seat View()
        {
            return this;
        }
    }
}
