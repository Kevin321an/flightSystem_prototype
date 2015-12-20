using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Define the pattern of user groups class to reduce the redundence
    /// </summary>
    abstract class SpecialFlightObserverAbstract : SpecialFlightObserver
    {

        public string _name;
        public AirLinePrice _flight;
        public const double SLIVER_DISCOUNT_RATE = 0.9; //discount rate
        public const double Golden_DISCOUNT_RATE = 0.8;

        public virtual void Update(AirLinePrice flight)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
            "change to {2:C}", _name, flight.Symbol, flight.Price);
        }

        // Gets or sets the flight
        public AirLinePrice Flight
        {
            get { return _flight; }
            set { _flight = value; }
        }
    }
}
