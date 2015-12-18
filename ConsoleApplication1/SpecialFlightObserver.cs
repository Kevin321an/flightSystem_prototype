using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// The 'SpecialFlightObserver' interface
    /// </summary>
    interface SpecialFlightObserver
    {
        SpecialFlightObserverAbstract SpecialFlightObserverAbstract
        {
            get;
            set;
        }
    
        void Update(AirLinePrice flight);
    }
}
