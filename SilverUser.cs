using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// The 'SilverUser' class
    /// </summary>
    class SilverUser : SpecialFlightObserverAbstract, SpecialFlightObserver
    {

        // define the name of this costomer group 
        public SilverUser(string name)
        {
            this._name = name;
        }
        /// <summary>
        /// over write the method to show the different output by using discount rate
        /// </summary>
        /// <param name="flight">AirLinePrice object</param>
        public override void Update(AirLinePrice flight)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", _name, flight.Symbol, flight.Price * SLIVER_DISCOUNT_RATE);
        }
    }
}
