using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    // <summary>
    /// The 'RegisteredUser' class
    /// </summary>
    class RegisteredUser : SpecialFlightObserverAbstract, Account, SpecialFlightObserver
    {
        // define the name of this costomer group 
        public RegisteredUser(string name)
        {
            this._name = name;
        }
    }
}
