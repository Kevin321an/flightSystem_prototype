using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// The AirLinePrice class
    /// </summary> 
    abstract class AirLinePrice
    {
        private string _flight;
        private double _price;
        private List<SpecialFlightObserver> _customerGroups = new List<SpecialFlightObserver>();

        /// <summary>
        /// Give it flight number and its price 
        /// </summary>
        /// <param name="flight">flight number</param>
        /// <param name="price">price </param>
        public AirLinePrice(string flight, double price)
        {
            this._flight = flight;
            this._price = price;
        }
        /// <summary>
        /// add the customerGroup(observer) to the flight
        /// </summary>
        /// <param name="customerGroup">customerGroup</param>
        public void Attach(SpecialFlightObserver customerGroup)
        {
            _customerGroups.Add(customerGroup);
        }
        /// <summary>
        /// remove the customerGroup(observer) to the flight
        /// </summary>
        /// <param name="customerGroup">customerGroup</param>

        public void Detach(SpecialFlightObserver customerGroup)
        {
            _customerGroups.Remove(customerGroup);
        }
        /// <summary>
        /// iterating customergroups this flight has been added and update them
        /// </summary>
        public void Notify()
        {
            foreach (SpecialFlightObserver customerGroup in _customerGroups)
            {
                customerGroup.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the price and call Notify() when the price has been changed
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Gets the flight
        public string Symbol
        {
            get { return _flight; }
        }

        internal SpecialFlightObserver SpecialFlightObserver
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
