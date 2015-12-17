using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
    {/// <summary>
     /// The Aircraftclass
     /// </summary>   
    public class Airport
    {
        private string location;
        private string ataCode;

        public Airport()
        {
            
        }
        /// <summary>
        /// view airport information 
        /// </summary>
        /// <returns></returns>
        public Airport ViewAirport()
        {
            return this;
        }
        /// <summary>
        /// delete airport 
        /// </summary>
        /// <param name="airport"></param>
        public void Delete(Airport airport)
        {
            
        }
        /// <summary>
        /// update airport
        /// </summary>
        /// <param name="airport"></param>
        public void Update(Airport airport)
        {
            
        }
        /// <summary>
        /// perporty of location
        /// </summary>

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string AtaCode
        {
            get { return ataCode; }
            set { ataCode = value; }
        }
    }
}
