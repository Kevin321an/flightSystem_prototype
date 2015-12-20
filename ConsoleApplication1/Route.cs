using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The Route class for flight
    /// </summary>
    public class Route
    {
        private Airport to;
        /// <summary>
        /// destination
        /// </summary>
        public Airport To
        {
            get { return to; }
            set { to = value; }
        }
        private Airport from;
        /// <summary>
        /// depature
        /// </summary>
        public Airport From
        {
            get { return from; }
            set { from = value; }
        }

        public Route()
        {
            
        }
        /// <summary>
        /// update the route
        /// </summary>
        /// <param name="route"></param>
        public void Update(Route route)
        {
           
        }
        /// <summary>
        /// delete the route
        /// </summary>
        /// <param name="route"></param>
        public void Delete(Route route)
        {
           
        }
        //View the route
        public Route View()
        {
            return this;
        }
    }
}
