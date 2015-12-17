using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Route
    {
        private Airport to;

        public Airport To
        {
            get { return to; }
            set { to = value; }
        }
        private Airport from;

        public Airport From
        {
            get { return from; }
            set { from = value; }
        }

        public Route()
        {
            
        }

        public void Update(Route route)
        {
           
        }

        public void Delete(Route route)
        {
           
        }

        public Route View()
        {
            return this;
        }
    }
}
