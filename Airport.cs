using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Airport
    {
        private string location;
        private string ataCode;

        public Airport()
        {
            
        }

        public Airport ViewAirport()
        {
            return this;
        }

        public void Delete(Airport airport)
        {
            
        }

        public void Update(Airport airport)
        {
            
        }

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
